using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.WinForms.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        public TelaItemForm()
        {
            InitializeComponent();
        }
        public Item ObterItem()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = (txtNome.Text);
            decimal valor;

            try
            {
                valor = decimal.Parse(txtValor.Text);
            }
            catch
            {
                valor = -1;
            }

            Item item = new Item(nome, valor);
            item.id = id;

            return item;
        }
        public void ConfigurarValoresNaTela(Item itemSelecionado)
        {
            txtId.Text = itemSelecionado.id.ToString();
            txtNome.Text = itemSelecionado.Nome;
            txtValor.Text = itemSelecionado.Valor.ToString();
        }

        private void Validar(Item item)
        {
            string[] erros = item.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Item item = ObterItem();

            Validar(item);
        }
    }
}
