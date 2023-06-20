using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.Infra.Dados.Arquivo.ModuloItem;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        RepositorioItemEmArquivo repositorioItem;
        List<Tema> listaTemas;
        public TelaTemaForm(List<Item> itens, List<Tema> listaTemas)
        {
            InitializeComponent();

            this.listaTemas = listaTemas;

            ConfigurarListaItem(itens);
        }

        public Tema ObterTema()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nomeTema = txtNome.Text;

            Tema tema = new Tema(nomeTema);
            tema.id = id;

            tema.listaItens.AddRange(chListItens.CheckedItems.Cast<Item>());

            return tema;
        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtNome.Text = temaSelecionado.Nome;

            int i = 0;

            for (int j = 0; j < chListItens.Items.Count; j++)
            {
                Item item = (Item)chListItens.Items[j];

                if (temaSelecionado.listaItens.Contains(item))
                {
                    chListItens.SetItemChecked(i, true);
                }

                i++;
            }
        }

        public void ConfigurarListaItem(List<Item> itens)
        {
            chListItens.Items.Clear();

            chListItens.Items.AddRange(itens.ToArray());
        }

        private void Validar(Tema tema)
        {
            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            foreach (Tema t in listaTemas)
            {
                if (tema.Nome == t.Nome && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome ja esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();

            Validar(tema);
        }
    }
}