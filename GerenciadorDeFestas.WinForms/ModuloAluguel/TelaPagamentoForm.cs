using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaPagamentoForm : Form
    {
        public TelaPagamentoForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Enum PorcentagemEntrada(Aluguel aluguelSelecionado)
        {
            if(rbt40.Checked)
            {
                return aluguelSelecionado.PorcentagemPaga = PorcentagemPagaEnum.Quarenta;
            }
            else if(rbt50.Checked) 
            {
                return aluguelSelecionado.PorcentagemPaga = PorcentagemPagaEnum.Cinquenta;
            }
            else if (rbt100.Checked)
            {
                return aluguelSelecionado.PorcentagemPaga = PorcentagemPagaEnum.Cem;
            }

            return aluguelSelecionado.PorcentagemPaga = PorcentagemPagaEnum.Zero;

        }
        public void ConfigurarValoresNaTela(Aluguel aluguelSelecionado)
        {
            PorcentagemPagaEnum porcentagemPaga = aluguelSelecionado.PorcentagemPaga;

            switch (porcentagemPaga)
            {
                case PorcentagemPagaEnum.Quarenta: rbt40.Checked = true; break;

                case PorcentagemPagaEnum.Cinquenta: rbt50.Checked = true; break;

                case PorcentagemPagaEnum.Cem: rbt100.Checked = true; break;
            }
        }
    }
}
