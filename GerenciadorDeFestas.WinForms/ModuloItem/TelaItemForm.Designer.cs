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
            txtId.Location = new Point(451, 51);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(422, 55);
            label2.Name = "label2";
            label2.Size = new Size(29, 23);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.BackgroundImage = Properties.Resources.Colorful_Modern_Geometric_Background_Desktop_Wallpaper__1_;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(275, 187);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(101, 55);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = Properties.Resources.fundo2;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(383, 187);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 55);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(74, 127);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(111, 27);
            txtValor.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(18, 131);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 18;
            label1.Text = "Valor:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(74, 51);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(322, 27);
            txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNome.Location = new Point(18, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 23);
            lblNome.TabIndex = 16;
            lblNome.Text = "Nome:";
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(497, 257);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaItemForm";
            ShowIcon = false;
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