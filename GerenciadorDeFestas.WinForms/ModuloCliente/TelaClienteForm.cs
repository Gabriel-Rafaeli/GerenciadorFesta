using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;

        public TelaClienteForm(List<Cliente> clientes)
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Cliente ObterCliente()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            bool ClienteAntigo = rdbAntigo.Checked;
            bool ClienteNovo = rdbNovo.Checked;

            cliente = new Cliente(nome, telefone, ClienteAntigo, ClienteNovo);
            cliente.id = id;

            return cliente;
        }

        public void ConfigurarTela(Cliente clienteSelecionado)
        {
            txtId.Text = clienteSelecionado.id.ToString();
            txtNome.Text = clienteSelecionado.Nome;
            txtTelefone.Text = clienteSelecionado.Telefone;

            if (clienteSelecionado.ClienteAntigo)
                rdbAntigo.Checked = true;
            else
                rdbNovo.Checked = true;
        }

        private void Validar(Cliente cliente)
        {
            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObterCliente();

            Validar(cliente);
        }
    }
}
