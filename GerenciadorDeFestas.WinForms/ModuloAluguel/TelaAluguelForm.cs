using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        public TelaAluguelForm(List<Cliente> listaClientes, List<Tema> listaTemas)
        {
            InitializeComponent();

            ConfigurarComboBoxCliente(listaClientes);

            ConfigurarComboBoxTema(listaTemas);
        }

        public Aluguel ObterAluguel()
        {
            int id = Convert.ToInt32(txtId.Text);
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            Tema tema = (Tema)cmbTema.SelectedItem;
            DateTime data = dtpData.Value;
            DateTime horaInicio = dtpHoraInicio.Value;
            DateTime horaFinal = dtpHoraFinal.Value;
            DateTime dataFechamento = dtpDataFechamento.Value;
            string cep = txtCep.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;

            Aluguel aluguel = new Aluguel(cliente, tema, data, horaInicio, horaFinal, dataFechamento, cep, rua, numero);

            aluguel.id = id;

            return aluguel;

        }

        public void ConfigurarValoresNaTela(Aluguel aluguelSelecionado)
        {
            txtId.Text = aluguelSelecionado.id.ToString();
            cmbCliente.Text = aluguelSelecionado.Cliente.ToString();
            cmbTema.Text = aluguelSelecionado.Tema.ToString(); 
            dtpData.Value = aluguelSelecionado.Data;
            dtpHoraInicio.Value = aluguelSelecionado.HoraInicio;
            dtpHoraFinal.Value = aluguelSelecionado.HoraFinal;
            dtpDataFechamento.Value = aluguelSelecionado.DataFechamento;
            txtCep.Text = aluguelSelecionado.Cep;
            txtRua.Text = aluguelSelecionado.Rua;
            txtNumero.Text = aluguelSelecionado.Numero;

        }

        public void ConfigurarComboBoxCliente(List<Cliente> listaClientes)
        {
            foreach (Cliente cliente in listaClientes)
            {
                cmbCliente.Items.Add(cliente);
            }
        }

        public void ConfigurarComboBoxTema(List<Tema> listaTemas)
        {
            foreach (Tema tema in listaTemas)
            {
                cmbTema.Items.Add(tema);
            }
        }
    }
}
