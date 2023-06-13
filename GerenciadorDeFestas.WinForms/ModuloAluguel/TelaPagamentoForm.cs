using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaPagamentoForm : Form
    {
        public TelaPagamentoForm()
        {
            InitializeComponent();
        }

        public Enum PorcentagemEntrada(Aluguel aluguelSelecionado)
        {
            if(rbt40.Checked)
            {
                return aluguelSelecionado.PorcentagemPaga = PorcentagemPaga.Quarenta;
            }
            else if(rbt50.Checked) 
            {
                return aluguelSelecionado.PorcentagemPaga = PorcentagemPaga.Cinquenta;
            }
            else if (rbt100.Checked)
            {
                return aluguelSelecionado.PorcentagemPaga = PorcentagemPaga.Cem;
            }

            return aluguelSelecionado.PorcentagemPaga = PorcentagemPaga.Zero;

        }
    }
}
