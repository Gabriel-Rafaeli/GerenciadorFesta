using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using System.Drawing;

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
            string cep = txtCep.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;

            Aluguel aluguel = new Aluguel(cliente, tema, data, horaInicio, horaFinal, cep, rua, numero);

            aluguel.id = id;

            aluguel.ValorPagar = tema.ValorTotal;

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

        private void Validar(Aluguel aluguel)
        {
            string[] erros = aluguel.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            else if (cmbCliente.SelectedIndex == -1)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape( "Nenhum Cliente selecionado!");

                DialogResult = DialogResult.None;
            }

            else if(cmbTema.SelectedIndex == -1)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum Tema selecionado!");

                DialogResult = DialogResult.None;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = ObterAluguel();

            Validar(aluguel);
        }
    }
}
