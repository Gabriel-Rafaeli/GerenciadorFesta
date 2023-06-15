namespace GerenciadorDeFestas.WinForms.ModuloItem
{
    partial class TelaItemForm
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
            txtValor = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(395, 38);
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
            label2.Location = new Point(369, 41);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.BackgroundImage = Properties.Resources.Colorful_Modern_Geometric_Background_Desktop_Wallpaper__1_;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(241, 140);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = Properties.Resources.fundo2;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(335, 140);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(65, 95);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(98, 23);
            txtValor.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(16, 98);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 18;
            label1.Text = "Valor:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(282, 23);
            txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNome.Location = new Point(16, 41);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 17);
            lblNome.TabIndex = 16;
            lblNome.Text = "Nome:";
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(435, 193);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            DoubleBuffered = true;
            Name = "TelaItemForm";
            Text = "Cadastro de Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtValor;
        private Label label1;
        private TextBox txtNome;
        private Label lblNome;
    }
}