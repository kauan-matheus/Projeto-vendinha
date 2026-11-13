using System.ComponentModel.DataAnnotations;
using Vendinha.Context;
using Vendinha.Models;

namespace Vendinha.Services
{
    public class ClienteService
    {
        public const int ItensPorPagina = 10;

        private VendinhaDbContext context;

        //esse construtor vai ser usado quando eu quiser passar um context q ja existe
        public ClienteService(VendinhaDbContext context)
        {
            this.context = context;
        }

        //esse aqui eu vou usar pra criar as telas ai nn passo o context, ele vai criar um novo context pra mim
        public ClienteService() : this(new VendinhaDbContext())
        {

        }

        public List<Cliente> Consultar(string busca, int pagina) // fazendo filtragem, ordenação e paginação
        {
            var resultado = context.Clientes
                .Where(c => c.Nome.ToLower().Contains(busca.ToLower()))
                .OrderByDescending(c => context.Dividas
                    .Where(d => d.ClienteId == c.Id && !d.Paga)
                    .Sum(d => d.Valor))
                .ThenBy(c => c.Nome)
                .Skip((pagina - 1) * ItensPorPagina)
                .Take(ItensPorPagina)
                .ToList();

            return resultado;
        }

        public int TotalPaginas(string busca)
        {
            var total = context.Clientes.Count(c => c.Nome.ToLower().Contains(busca.ToLower()));
            var paginas = (int)Math.Ceiling(total / (double)ItensPorPagina);

            if (paginas == 0)
                return 1;

            return paginas;
        }

        public decimal TotalDevido(int clienteId)
        {
            var total = context.Dividas
                .Where(d => d.ClienteId == clienteId && !d.Paga)
                .Sum(d => d.Valor);

            return total;
        }

        public bool Criar(Cliente cliente, out List<ValidationResult> erros)
        {
            if (!Validar(cliente, out erros))
                return false;

            cliente.DataNascimento = cliente.DataNascimento.ToUniversalTime();

            context.Clientes.Add(cliente);
            context.SaveChanges();
            return true;
        }

        public bool Editar(Cliente cliente, out List<ValidationResult> erros)
        {
            if (!Validar(cliente, out erros))
                return false;

            var existente = context.Clientes.First(c => c.Id == cliente.Id);
            existente.Nome = cliente.Nome;
            existente.Cpf = cliente.Cpf;
            existente.DataNascimento = cliente.DataNascimento.ToUniversalTime();
            existente.Email = cliente.Email;

            context.SaveChanges();
            return true;
        }

        public void Excluir(int id)
        {
            var dividas = context.Dividas.Where(d => d.ClienteId == id).ToList();
            context.Dividas.RemoveRange(dividas);
            context.SaveChanges();

            var cliente = context.Clientes.First(c => c.Id == id);
            context.Clientes.Remove(cliente);

            context.SaveChanges();
        }

        public bool Validar(Cliente cliente, out List<ValidationResult> erros)
        {
            var vcontext = new ValidationContext(cliente);
            erros = new List<ValidationResult>();
            var valido = Validator.TryValidateObject(cliente, vcontext, erros, true);

            var cpfEmUso = context.Clientes.Any(c => c.Cpf == cliente.Cpf && c.Id != cliente.Id);
            if (cpfEmUso)
            {
                erros.Add(new ValidationResult("Ja existe um cliente com esse CPF"));
                valido = false;
            }

            return valido;
        }
    }
}
