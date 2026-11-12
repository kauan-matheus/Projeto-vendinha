using System.ComponentModel.DataAnnotations;

namespace Vendinha.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome completo")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; } = "";

        private string cpf = "";
        [Required(ErrorMessage = "Informe o CPF")]
        public string Cpf
        {
            get { return this.cpf; }
            set
            {
                this.cpf = (value ?? "").Replace(".", "").Replace("-", "").Trim();
            }
        }

        public DateTime DataNascimento { get; set; }

        private string? email;
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string? Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.email = null;
                }
                else
                {
                    this.email = value.ToLower().Trim();
                }
            }
        }

        public int Idade
        {
            get
            {
                var hoje = DateTime.Today;
                var nascimento = DataNascimento.Date;
                var idade = hoje.Year - nascimento.Year;
                if (nascimento > hoje.AddYears(-idade))
                {
                    idade--;
                }
                return idade;
            }
        }
    }
}
