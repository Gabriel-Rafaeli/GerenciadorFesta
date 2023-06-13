﻿using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            grid.Rows.Clear();
            foreach (Tema tema in temas)
            {
                grid.Rows.Add(tema.id, tema.Nome, tema.ValorTotal);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {temas.Count} cliente(s)");
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
                    Name = "nome",
                    HeaderText = "Tema"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Valor total"
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