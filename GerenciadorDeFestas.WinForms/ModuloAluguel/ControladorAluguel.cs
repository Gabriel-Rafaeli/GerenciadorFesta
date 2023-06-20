using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.WinForms.Compartilhado;
using GerenciadorDeFestas.WinForms.ModuloCliente;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;
        private IRepositorioAluguel repositorioAluguel;

        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema, IRepositorioAluguel repositorioAluguel)
        {
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
            this.repositorioAluguel = repositorioAluguel;
        }

        public override string ToolTipInserir => "Inserir novo Aluguel";

        public override string ToolTipEditar => "Editar Aluguel Existente";

        public override string ToolTipExcluir => "Excluir Aluguel Existente";

        public override string ToolTipPagamento => "Conferir informações do Pagamento";

        public override bool PagamentoHabilitado => true;

        public override void Inserir()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());
            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguelSelecionado = telaAluguel.ObterAluguel();

                aluguelSelecionado.CalcularValorPagar();

                aluguelSelecionado.Cliente.listaAlugueisDoCliente.Add(aluguelSelecionado);
                aluguelSelecionado.Tema.listaAlugueis.Add(aluguelSelecionado);

                repositorioAluguel.Inserir(aluguelSelecionado);
            }
            CarregarAlugueis();
        }

        public override void Editar()
        {
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Edição de Aluguel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());
            telaAluguel.ConfigurarValoresNaTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();

                repositorioAluguel.Editar(aluguel.id, aluguel);

                aluguel.CalcularValorPagar();
                
            }
            CarregarAlugueis();
        }

        public override void Excluir()
        {
            Aluguel aluguel = ObterAluguelSelecionado();

            if (aluguel == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Exclusão de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Aluguel {aluguel.Cliente.Nome}?", "Exclusão de Alugueis",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Excluir(aluguel);

                CarregarAlugueis();
            }
        }

        public override void Pagamento()
        {
            TelaPagamentoForm telaPagamento = new TelaPagamentoForm();

            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Edição de Aluguel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (BloquearBotaoPagamento(aluguelSelecionado))
                return;

            telaPagamento.ConfigurarValoresNaTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaPagamento.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                telaPagamento.PorcentagemEntrada(aluguelSelecionado);

                aluguelSelecionado.ValorPagar = aluguelSelecionado.CalcularValorPagar();

                

                repositorioAluguel.AtualizarPagamentoJson(aluguelSelecionado.id, aluguelSelecionado);

                aluguelSelecionado.FinalizarPagamento();
            }
            
            CarregarAlugueis();
        }    

        public override UserControl ObterListagem()
        {
            if(tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Aluguel";
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> listaAlugueis = repositorioAluguel.SelecionarTodos();
            tabelaAluguel.AtualizarRegistros(listaAlugueis);
        }

        private Aluguel ObterAluguelSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();

            return repositorioAluguel.SelecionarPorId(id);
        }

        private bool BloquearBotaoPagamento(Aluguel aluguel)
        {
            if(aluguel.PorcentagemPaga == PorcentagemPagaEnum.Cem) 
            {
                MessageBox.Show($"Pagamento já finalizado!",
                    "Pagamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
        }
    }
}
