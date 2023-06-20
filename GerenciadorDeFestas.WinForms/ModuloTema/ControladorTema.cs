using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public class ControladorTema : ControladorBase
    {

        private IRepositorioTema repositorioTema;
        private IRepositorioItem repositorioItem;
        private TabelaTemaControl tabelaTema;


        public ControladorTema(IRepositorioTema repositorioTema, IRepositorioItem repositorioItem)
        {
            this.repositorioTema = repositorioTema;
            this.repositorioItem = repositorioItem;
        }

        public override string ToolTipInserir => "Inserir novo tema";

        public override string ToolTipEditar => "Editar tema existente";

        public override string ToolTipExcluir => "Excluir tema existente";

        public override void Inserir()
        {
            TelaTemaForm telaTema = new TelaTemaForm(repositorioItem.SelecionarTodos(), repositorioTema.SelecionarTodos());

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                tema.CalcularValor();

                repositorioTema.Inserir(tema);

                CarregarTemas();

            }
        }

        public override void Editar()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro", "Edicao de Tema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTemaForm telaTema = new TelaTemaForm(repositorioItem.SelecionarTodos(), repositorioTema.SelecionarTodos());
            telaTema.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                if (temaSelecionado.listaAlugueis.Count() > 0)
                {
                    MessageBox.Show("Exclusão inválida! CTema possui aluguel(éis)", "Excluir tema existente",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                repositorioTema.Excluir(temaSelecionado);
            }

            CarregarTemas();
        }

        public override void Excluir()
        {
            Tema tema = ObterTemaSelecionado();

            if (tema == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Exclusão de tema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o tema {tema.Nome}?", "Exclusão de temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                if (tema.listaAlugueis.Count() > 0)
                {
                    MessageBox.Show("Exclusão inválida! Tema possui aluguel(éis)", "Excluir tema existente",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                repositorioTema.Excluir(tema);
            }
            CarregarTemas();
        }

        private Tema ObterTemaSelecionado()
        {
            int id = tabelaTema.ObterIdSelecionado();

            return repositorioTema.SelecionarPorId(id);

        }

        private void CarregarTemas()
        {
            List<Tema> tema = repositorioTema.SelecionarTodos();

            tabelaTema.AtualizarRegistros(tema);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTema;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }
    }
}

