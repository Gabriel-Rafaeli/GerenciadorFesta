using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.WinForms.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();
            foreach (Aluguel aluguel in alugueis)
            {
                grid.Rows.Add(aluguel.id, aluguel.Cliente, aluguel.Tema, aluguel.Data, aluguel.DataFechamento, aluguel.Cep, aluguel.PorcentagemPaga, aluguel.ValorPagar);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueis.Count} Aluguel(is)");
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cliente",
                    HeaderText = "Cliente"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "tema",
                    HeaderText = "Tema"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Fechamento",
                    HeaderText = "Fechamento"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cep",
                    HeaderText = "Cep"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "porcentagemPaga",
                    HeaderText = "% Pago"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorPagar",
                    HeaderText = "Valor a Pagar"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
