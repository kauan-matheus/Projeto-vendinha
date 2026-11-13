using Vendinha.Desktop.Screens;
using Vendinha.Services;

namespace Vendinha.Desktop
{
    public partial class Form1 : Form
    {
        private ClienteService clienteService = new ClienteService();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            using var tela = new ListarClientes(clienteService);
            tela.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using var tela = new CadastrarCliente(clienteService);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "Cliente cadastrado com sucesso!";
            }
        }
    }
}
