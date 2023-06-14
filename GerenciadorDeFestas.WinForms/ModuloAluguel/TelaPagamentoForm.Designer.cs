namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    partial class TelaPagamentoForm
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
            txtId = new TextBox();
            label2 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            lblPorcentagemPaga = new Label();
            rbt40 = new RadioButton();
            rbt50 = new RadioButton();
            rbt100 = new RadioButton();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(323, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(297, 15);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.BackgroundImage = Properties.Resources.Colorful_Modern_Geometric_Background_Desktop_Wallpaper__1_;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(169, 87);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = Properties.Resources.fundo2;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(263, 87);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPorcentagemPaga
            // 
            lblPorcentagemPaga.AutoSize = true;
            lblPorcentagemPaga.BackColor = Color.Transparent;
            lblPorcentagemPaga.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPorcentagemPaga.ForeColor = Color.MidnightBlue;
            lblPorcentagemPaga.Location = new Point(30, 20);
            lblPorcentagemPaga.Name = "lblPorcentagemPaga";
            lblPorcentagemPaga.Size = new Size(162, 17);
            lblPorcentagemPaga.TabIndex = 11;
            lblPorcentagemPaga.Text = "Porcentagem de Entrada:";
            // 
            // rbt40
            // 
            rbt40.AutoSize = true;
            rbt40.BackColor = Color.Transparent;
            rbt40.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            rbt40.ForeColor = Color.MidnightBlue;
            rbt40.Location = new Point(40, 47);
            rbt40.Name = "rbt40";
            rbt40.Size = new Size(51, 21);
            rbt40.TabIndex = 12;
            rbt40.TabStop = true;
            rbt40.Text = "40%";
            rbt40.UseVisualStyleBackColor = false;
            // 
            // rbt50
            // 
            rbt50.AutoSize = true;
            rbt50.BackColor = Color.Transparent;
            rbt50.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            rbt50.ForeColor = Color.MidnightBlue;
            rbt50.Location = new Point(40, 74);
            rbt50.Name = "rbt50";
            rbt50.Size = new Size(51, 21);
            rbt50.TabIndex = 13;
            rbt50.TabStop = true;
            rbt50.Text = "50%";
            rbt50.UseVisualStyleBackColor = false;
            // 
            // rbt100
            // 
            rbt100.AutoSize = true;
            rbt100.BackColor = Color.Transparent;
            rbt100.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            rbt100.ForeColor = Color.MidnightBlue;
            rbt100.Location = new Point(40, 101);
            rbt100.Name = "rbt100";
            rbt100.Size = new Size(56, 21);
            rbt100.TabIndex = 14;
            rbt100.TabStop = true;
            rbt100.Text = "100%";
            rbt100.UseVisualStyleBackColor = false;
            // 
            // TelaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(370, 143);
            Controls.Add(rbt100);
            Controls.Add(rbt50);
            Controls.Add(rbt40);
            Controls.Add(lblPorcentagemPaga);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            DoubleBuffered = true;
            Name = "TelaPagamentoForm";
            Text = "Pagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private Label lblPorcentagemPaga;
        private RadioButton rbt40;
        private RadioButton rbt50;
        private RadioButton rbt100;
    }
}