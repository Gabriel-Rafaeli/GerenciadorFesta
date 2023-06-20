using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        List<Cliente> listaClientes;
        public TelaClienteForm(List<Cliente> listaClientes)
        {
            InitializeComponent();

            this.listaClientes = listaClientes;

            this.ConfigurarDialog();
        }

        public Cliente ObterCliente()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;

            cliente = new Cliente(nome, telefone);
            cliente.id = id;

            return cliente;
        }

        public void ConfigurarTela(Cliente clienteSelecionado)
        {
            txtId.Text = clienteSelecionado.id.ToString();
            txtNome.Text = clienteSelecionado.Nome;
            txtTelefone.Text = clienteSelecionado.Telefone;
        }

        private void Validar(Cliente cliente)
        {
            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            foreach (Cliente c in listaClientes)
            {
                if (cliente.Nome.ToUpper() == c.Nome.ToUpper() && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome ja esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObterCliente();

            Validar(cliente);
        }
    }
}
