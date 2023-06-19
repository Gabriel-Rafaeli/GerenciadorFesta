namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    partial class TelaListagemAlugueisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            listagem = new TabelaListagemAlugueisControl();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(12, 34);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(73, 30);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // listagem
            // 
            listagem.Location = new Point(12, 89);
            listagem.Name = "listagem";
            listagem.Size = new Size(716, 406);
            listagem.TabIndex = 1;
            // 
            // TelaListagemAlugueisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 507);
            Controls.Add(listagem);
            Controls.Add(lblNome);
            Name = "TelaListagemAlugueisForm";
            ShowIcon = false;
            Text = "TelaListagemAlugueisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TabelaListagemAlugueisControl listagem;
    }
}