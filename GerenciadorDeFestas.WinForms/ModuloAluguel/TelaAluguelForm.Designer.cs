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
            dtpHoraInicio = new DateTimePicker();
            dtpHoraFinal = new DateTimePicker();
            lblHoraFinal = new Label();
            txtCep = new TextBox();
            lblCep = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            dtpDataFechamento = new DateTimePicker();
            lblDataFechamento = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(583, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(557, 15);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(429, 340);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(523, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(69, 25);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 11;
            lblCliente.Text = "Cliente:";
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(78, 67);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(38, 15);
            lblTema.TabIndex = 13;
            lblTema.Text = "Tema:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(82, 103);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 15;
            lblData.Text = "Data:";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Location = new Point(48, 140);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(68, 15);
            lblHoraInicio.TabIndex = 17;
            lblHoraInicio.Text = "Hora Inicio:";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(122, 236);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(121, 23);
            txtRua.TabIndex = 20;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(86, 239);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(30, 15);
            lblRua.TabIndex = 19;
            lblRua.Text = "Rua:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(122, 22);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 21;
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(122, 64);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(121, 23);
            cmbTema.TabIndex = 22;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(122, 103);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(121, 23);
            dtpData.TabIndex = 23;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.Format = DateTimePickerFormat.Short;
            dtpHoraInicio.Location = new Point(122, 134);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.Size = new Size(121, 23);
            dtpHoraInicio.TabIndex = 24;
            // 
            // dtpHoraFinal
            // 
            dtpHoraFinal.Format = DateTimePickerFormat.Short;
            dtpHoraFinal.Location = new Point(122, 163);
            dtpHoraFinal.Name = "dtpHoraFinal";
            dtpHoraFinal.Size = new Size(121, 23);
            dtpHoraFinal.TabIndex = 26;
            // 
            // lblHoraFinal
            // 
            lblHoraFinal.AutoSize = true;
            lblHoraFinal.Location = new Point(52, 169);
            lblHoraFinal.Name = "lblHoraFinal";
            lblHoraFinal.Size = new Size(64, 15);
            lblHoraFinal.TabIndex = 25;
            lblHoraFinal.Text = "Hora Final:";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(122, 265);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(121, 23);
            txtCep.TabIndex = 28;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(85, 268);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 27;
            lblCep.Text = "Cep:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(122, 294);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 30;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(62, 297);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 29;
            lblNumero.Text = "Numero:";
            // 
            // dtpDataFechamento
            // 
            dtpDataFechamento.Format = DateTimePickerFormat.Short;
            dtpDataFechamento.Location = new Point(122, 198);
            dtpDataFechamento.Name = "dtpDataFechamento";
            dtpDataFechamento.Size = new Size(121, 23);
            dtpDataFechamento.TabIndex = 32;
            // 
            // lblDataFechamento
            // 
            lblDataFechamento.AutoSize = true;
            lblDataFechamento.Location = new Point(13, 204);
            lblDataFechamento.Name = "lblDataFechamento";
            lblDataFechamento.Size = new Size(103, 15);
            lblDataFechamento.TabIndex = 31;
            lblDataFechamento.Text = "Data Fechamento:";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 393);
            Controls.Add(dtpDataFechamento);
            Controls.Add(lblDataFechamento);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtCep);
            Controls.Add(lblCep);
            Controls.Add(dtpHoraFinal);
            Controls.Add(lblHoraFinal);
            Controls.Add(dtpHoraInicio);
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
            Name = "TelaAluguelForm";
            Text = "TelaAluguelForm";
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
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFinal;
        private Label lblHoraFinal;
        private TextBox txtCep;
        private Label lblCep;
        private TextBox txtNumero;
        private Label lblNumero;
        private DateTimePicker dtpDataFechamento;
        private Label lblDataFechamento;
    }
}