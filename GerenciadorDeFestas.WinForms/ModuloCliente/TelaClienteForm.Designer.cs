namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    partial class TelaClienteForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            rdbAntigo = new RadioButton();
            rdbNovo = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(350, 139);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(256, 139);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // rdbAntigo
            // 
            rdbAntigo.AutoSize = true;
            rdbAntigo.BackColor = Color.Transparent;
            rdbAntigo.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            rdbAntigo.Location = new Point(253, 95);
            rdbAntigo.Name = "rdbAntigo";
            rdbAntigo.Size = new Size(67, 21);
            rdbAntigo.TabIndex = 2;
            rdbAntigo.TabStop = true;
            rdbAntigo.Text = "Antigo";
            rdbAntigo.UseVisualStyleBackColor = false;
            // 
            // rdbNovo
            // 
            rdbNovo.AutoSize = true;
            rdbNovo.BackColor = Color.Transparent;
            rdbNovo.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            rdbNovo.Location = new Point(186, 95);
            rdbNovo.Name = "rdbNovo";
            rdbNovo.Size = new Size(59, 21);
            rdbNovo.TabIndex = 3;
            rdbNovo.TabStop = true;
            rdbNovo.Text = "Novo";
            rdbNovo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(19, 96);
            label1.Name = "label1";
            label1.Size = new Size(158, 17);
            label1.TabIndex = 4;
            label1.Text = "Escolha o tipo de cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(384, 24);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 5;
            label2.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(410, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 6;
            txtId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(30, 24);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 7;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(19, 59);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 8;
            label4.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(89, 21);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(282, 23);
            txtNome.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(89, 56);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(126, 23);
            txtTelefone.TabIndex = 10;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(456, 192);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rdbNovo);
            Controls.Add(rdbAntigo);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            DoubleBuffered = true;
            Name = "TelaClienteForm";
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private RadioButton rdbAntigo;
        private RadioButton rdbNovo;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtTelefone;
    }
}