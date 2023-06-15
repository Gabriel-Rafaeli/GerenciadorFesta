namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    partial class TelaTemaForm
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
            chListItens = new CheckedListBox();
            txtNome = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(467, 19);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(28, 23);
            txtId.ReadOnly = true;
            txtId.Size = new Size(31, 27);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(438, 23);
            label2.Name = "label2";
            label2.Size = new Size(29, 23);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.BackgroundImage = Properties.Resources.Colorful_Modern_Geometric_Background_Desktop_Wallpaper__1_;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.ForeColor = SystemColors.ControlText;
            btnGravar.Location = new Point(291, 296);
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
            btnCancelar.Location = new Point(399, 296);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 55);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // chListItens
            // 
            chListItens.FormattingEnabled = true;
            chListItens.Location = new Point(14, 69);
            chListItens.Margin = new Padding(3, 4, 3, 4);
            chListItens.Name = "chListItens";
            chListItens.Size = new Size(485, 180);
            chListItens.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 19);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(322, 27);
            txtNome.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(14, 23);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 15;
            label3.Text = "Tema:";
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(515, 375);
            Controls.Add(chListItens);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaTemaForm";
            ShowIcon = false;
            Text = "Cadastro de Temas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private CheckedListBox chListItens;
        private TextBox txtNome;
        private Label label3;
    }
}