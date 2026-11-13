using System.ComponentModel.DataAnnotations;
using Vendinha.Models;
using Vendinha.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class CadastrarCliente : Form
    {
        private ClienteService service;

        private Cliente? clienteEditando;

        public CadastrarCliente(ClienteService service)
        {
            InitializeComponent();
            this.service = service;
        }

        public CadastrarCliente(ClienteService service, Cliente cliente) : this(service) // chamando o construtor acima 
        {
            this.clienteEditando = cliente;

            lblTitulo.Text = "Editar Cliente";
            Text = "Editar Cliente";

            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            txtEmail.Text = cliente.Email;
            pickerData.Value = cliente.DataNascimento.ToLocalTime();
        }

        private void btnSalvar_Click(object sender, EventArgs e) 
        {
            var cliente = new Cliente
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                Email = txtEmail.Text,
                DataNascimento = pickerData.Value.Date
            };

            List<ValidationResult> erros;
            bool sucesso;

            try
            {
                if (clienteEditando == null) // se nn tiver cliente editando, e pq ta criando um novo cliente
                    sucesso = service.Criar(cliente, out erros);
                else
                {
                    cliente.Id = clienteEditando.Id;
                    sucesso = service.Editar(cliente, out erros);
                }
            }
            catch (Exception)
            {
                lblErros.Text = "Nao foi possivel salvar o cliente";
                return;
            }

            if (sucesso)
            {
                DialogResult = DialogResult.OK; // ai o form vai saber q deu certo e vai fechar a tela de cadastro
                Close();
                return;
            }

            lblErros.Text = "";
            foreach (var erro in erros)
            {
                lblErros.Text += erro.ErrorMessage + "\n"; // concatena os erros e mostra

            }
        }
    }
}
