namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    partial class TelaAluguelForm
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
            lblCliente = new Label();
            lblTema = new Label();
            lblData = new Label();
            lblHoraInicio = new Label();
            txtRua = new TextBox();
            lblRua = new Label();
            cmbCliente = new ComboBox();
            cmbTema = new ComboBox();
            dtpData = new DateTimePicker();
            lblHoraFinal = new Label();
            txtCep = new TextBox();
            lblCep = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            dtpHoraInicio = new DateTimePicker();
            dtpHoraFinal = new DateTimePicker();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(540, 23);
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
            label2.Location = new Point(504, 26);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.BackgroundImage = Properties.Resources.Colorful_Modern_Geometric_Background_Desktop_Wallpaper__1_;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(386, 227);
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
            btnCancelar.Location = new Point(480, 227);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.MidnightBlue;
            lblCliente.Location = new Point(42, 29);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 17);
            lblCliente.TabIndex = 11;
            lblCliente.Text = "Cliente:";
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.BackColor = Color.Transparent;
            lblTema.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblTema.ForeColor = Color.MidnightBlue;
            lblTema.Location = new Point(281, 30);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(43, 17);
            lblTema.TabIndex = 13;
            lblTema.Text = "Tema:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.BackColor = Color.Transparent;
            lblData.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblData.ForeColor = Color.MidnightBlue;
            lblData.Location = new Point(55, 75);
            lblData.Name = "lblData";
            lblData.Size = new Size(39, 17);
            lblData.TabIndex = 15;
            lblData.Text = "Data:";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.BackColor = Color.Transparent;
            lblHoraInicio.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblHoraInicio.ForeColor = Color.MidnightBlue;
            lblHoraInicio.Location = new Point(251, 76);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(77, 17);
            lblHoraInicio.TabIndex = 17;
            lblHoraInicio.Text = "Hora Inicio:";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(105, 113);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(121, 23);
            txtRua.TabIndex = 20;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.BackColor = Color.Transparent;
            lblRua.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblRua.ForeColor = Color.MidnightBlue;
            lblRua.Location = new Point(59, 115);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(34, 17);
            lblRua.TabIndex = 19;
            lblRua.Text = "Rua:";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(105, 26);
            cmbCliente.MaxDropDownItems = 12;
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 21;
            // 
            // cmbTema
            // 
            cmbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(335, 27);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(124, 23);
            cmbTema.TabIndex = 22;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(105, 72);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(121, 23);
            dtpData.TabIndex = 23;
            dtpData.Value = new DateTime(2023, 6, 14, 14, 18, 52, 0);
            // 
            // lblHoraFinal
            // 
            lblHoraFinal.AutoSize = true;
            lblHoraFinal.BackColor = Color.Transparent;
            lblHoraFinal.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblHoraFinal.ForeColor = Color.MidnightBlue;
            lblHoraFinal.Location = new Point(255, 113);
            lblHoraFinal.Name = "lblHoraFinal";
            lblHoraFinal.Size = new Size(73, 17);
            lblHoraFinal.TabIndex = 25;
            lblHoraFinal.Text = "Hora Final:";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(105, 142);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(121, 23);
            txtCep.TabIndex = 28;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCep.ForeColor = Color.MidnightBlue;
            lblCep.Location = new Point(58, 144);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(34, 17);
            lblCep.TabIndex = 27;
            lblCep.Text = "Cep:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(105, 171);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 30;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNumero.ForeColor = Color.MidnightBlue;
            lblNumero.Location = new Point(35, 173);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(61, 17);
            lblNumero.TabIndex = 29;
            lblNumero.Text = "Numero:";
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(335, 72);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(124, 23);
            dtpHoraInicio.TabIndex = 33;
            // 
            // dtpHoraFinal
            // 
            dtpHoraFinal.CustomFormat = "HH:mm";
            dtpHoraFinal.Format = DateTimePickerFormat.Custom;
            dtpHoraFinal.Location = new Point(334, 109);
            dtpHoraFinal.Name = "dtpHoraFinal";
            dtpHoraFinal.ShowUpDown = true;
            dtpHoraFinal.Size = new Size(125, 23);
            dtpHoraFinal.TabIndex = 34;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(581, 286);
            Controls.Add(dtpHoraFinal);
            Controls.Add(dtpHoraInicio);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtCep);
            Controls.Add(lblCep);
            Controls.Add(lblHoraFinal);
            Controls.Add(dtpData);
            Controls.Add(cmbTema);
            Controls.Add(cmbCliente);
            Controls.Add(txtRua);
            Controls.Add(lblRua);
            Controls.Add(lblHoraInicio);
            Controls.Add(lblData);
            Controls.Add(lblTema);
            Controls.Add(lblCliente);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaAluguelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alugueis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private Label lblCliente;
        private Label lblTema;
        private Label lblData;
        private Label lblHoraInicio;
        private TextBox txtRua;
        private Label lblRua;
        private ComboBox cmbCliente;
        private ComboBox cmbTema;
        private DateTimePicker dtpData;
        private Label lblHoraFinal;
        private TextBox txtCep;
        private Label lblCep;
        private TextBox txtNumero;
        private Label lblNumero;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFinal;
    }
}