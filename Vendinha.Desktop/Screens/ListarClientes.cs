using Vendinha.Models;
using Vendinha.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class ListarClientes : Form
    {
        private ClienteService service;

        private List<Cliente> clientesNaTela = new List<Cliente>();

        private int paginaAtual = 1;

        public ListarClientes(ClienteService service)
        {
            InitializeComponent();
            this.service = service;
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            try
            {
                var busca = txtBusca.Text;
                var totalPaginas = service.TotalPaginas(busca);

                if (paginaAtual > totalPaginas)
                {
                    paginaAtual = totalPaginas;
                }

                clientesNaTela = service.Consultar(busca, paginaAtual);

                dataGridView1.Rows.Clear();

                foreach (var cliente in clientesNaTela)
                {
                    dataGridView1.Rows.Add(
                        cliente.Nome,
                        cliente.Cpf,
                        cliente.Idade,
                        cliente.Email ?? "",
                        service.TotalDevido(cliente.Id).ToString("C"));
                }

                lblPagina.Text = $"Página {paginaAtual} de {totalPaginas}";
                btnAnterior.Enabled = paginaAtual > 1;
                btnProxima.Enabled = paginaAtual < totalPaginas;
            }
            catch (Exception)
            {
                clientesNaTela = new List<Cliente>();
                dataGridView1.Rows.Clear();
                btnAnterior.Enabled = false;
                btnProxima.Enabled = false;
                MostrarErro("Nao foi possivel carregar os clientes, verifique a conexao com o banco");
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
            paginaAtual = 1;
            CarregarClientes();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            paginaAtual--;
            CarregarClientes();
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            CarregarClientes();
        }

        private Cliente? ClienteSelecionado()
        {
            var linha = dataGridView1.CurrentRow;

            if (linha == null)
            {
                MostrarErro("Selecione um cliente na lista");
                return null;
            }

            return clientesNaTela[linha.Index];
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var cliente = ClienteSelecionado();
            if (cliente == null)
            {
                return;
            }

            using var tela = new CadastrarCliente(service, cliente);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                MostrarSucesso("Cliente alterado com sucesso!");
                CarregarClientes();
            }
        }

        private void btnDividas_Click(object sender, EventArgs e)
        {
            var cliente = ClienteSelecionado();
            if (cliente == null)
            {
                return;
            }

            using var tela = new DividasCliente();
            tela.ShowDialog();

            CarregarClientes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cliente = ClienteSelecionado();
            if (cliente == null)
            {
                return;
            }

            var resposta = MessageBox.Show(
                $"Excluir o cliente {cliente.Nome} e todas as dividas dele?",
                "Confirmar exclusao",
                MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                service.Excluir(cliente.Id);
            }
            catch (Exception)
            {
                MostrarErro("Nao foi possivel excluir o cliente, verifique a conexao com o banco");
                return;
            }

            MostrarSucesso($"Cliente {cliente.Nome} excluido");
            CarregarClientes();
        }

        private void MostrarSucesso(string mensagem)
        {
            lblMensagem.ForeColor = Color.Green;
            lblMensagem.Text = mensagem;
        }

        private void MostrarErro(string mensagem)
        {
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Text = mensagem;
        }
    }
}
