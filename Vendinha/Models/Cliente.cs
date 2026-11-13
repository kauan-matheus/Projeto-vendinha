using System.ComponentModel.DataAnnotations;

namespace Vendinha.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome completo")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "Informe o CPF")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve estar no formato 000.000.000-00")]
        public string Cpf { get; set; } = "";

        public DateTime DataNascimento { get; set; }

        private string? email;
        [EmailAddress(ErrorMessage = "E-mail invalido")]
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
