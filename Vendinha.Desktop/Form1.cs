using Vendinha.Desktop.Screens;

namespace Vendinha.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            using var tela = new ListarClientes();
            tela.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using var tela = new CadastrarCliente();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "Cliente cadastrado com sucesso!";
            }
        }
    }
}
