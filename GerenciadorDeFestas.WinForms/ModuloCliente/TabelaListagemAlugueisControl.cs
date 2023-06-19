﻿using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TabelaListagemAlugueisControl : UserControl
    {
        public TabelaListagemAlugueisControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "tema",
                    HeaderText = "Tema"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "pago",
                    HeaderText = "% paga"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorAhPagar",
                    HeaderText = "À pagar"
                },
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarGrid(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                grid.Rows.Add(aluguel.id, aluguel.Tema, aluguel.PorcentagemPaga, aluguel.ValorPagar.ToString("F2"));
            }

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueis.Count} Aluguel(éis)");
        }
    }
}
