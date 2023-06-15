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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.dtpDataFechamento = new System.Windows.Forms.DateTimePicker();
            this.lblDataFechamento = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(540, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(28, 23);
            this.txtId.TabIndex = 10;
            this.txtId.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(504, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id:";
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = global::GerenciadorDeFestas.WinForms.Properties.Resources.Colorful_Modern_Geometric_Background_Desktop_Wallpaper__1_;
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(386, 227);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(88, 41);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::GerenciadorDeFestas.WinForms.Properties.Resources.fundo2;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(480, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 41);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCliente.Location = new System.Drawing.Point(42, 29);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 17);
            this.lblCliente.TabIndex = 11;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.Transparent;
            this.lblTema.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTema.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTema.Location = new System.Drawing.Point(281, 30);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(43, 17);
            this.lblTema.TabIndex = 13;
            this.lblTema.Text = "Tema:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblData.Location = new System.Drawing.Point(55, 75);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 17);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraInicio.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHoraInicio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHoraInicio.Location = new System.Drawing.Point(251, 76);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(77, 17);
            this.lblHoraInicio.TabIndex = 17;
            this.lblHoraInicio.Text = "Hora Inicio:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(105, 169);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(121, 23);
            this.txtRua.TabIndex = 20;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.BackColor = System.Drawing.Color.Transparent;
            this.lblRua.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblRua.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRua.Location = new System.Drawing.Point(59, 171);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(34, 17);
            this.lblRua.TabIndex = 19;
            this.lblRua.Text = "Rua:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(105, 26);
            this.cmbCliente.MaxDropDownItems = 12;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 23);
            this.cmbCliente.TabIndex = 21;
            // 
            // cmbTema
            // 
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(335, 27);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(124, 23);
            this.cmbTema.TabIndex = 22;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(105, 72);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(121, 23);
            this.dtpData.TabIndex = 23;
            this.dtpData.Value = new System.DateTime(2023, 6, 14, 14, 18, 52, 0);
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraFinal.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHoraFinal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHoraFinal.Location = new System.Drawing.Point(255, 113);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(73, 17);
            this.lblHoraFinal.TabIndex = 25;
            this.lblHoraFinal.Text = "Hora Final:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(105, 198);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(121, 23);
            this.txtCep.TabIndex = 28;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCep.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCep.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCep.Location = new System.Drawing.Point(58, 200);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 17);
            this.lblCep.TabIndex = 27;
            this.lblCep.Text = "Cep:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(105, 227);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 23);
            this.txtNumero.TabIndex = 30;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNumero.Location = new System.Drawing.Point(35, 229);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(61, 17);
            this.lblNumero.TabIndex = 29;
            this.lblNumero.Text = "Numero:";
            // 
            // dtpDataFechamento
            // 
            this.dtpDataFechamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFechamento.Location = new System.Drawing.Point(105, 109);
            this.dtpDataFechamento.Name = "dtpDataFechamento";
            this.dtpDataFechamento.Size = new System.Drawing.Size(121, 23);
            this.dtpDataFechamento.TabIndex = 32;
            this.dtpDataFechamento.Value = new System.DateTime(2023, 6, 14, 14, 19, 2, 0);
            // 
            // lblDataFechamento
            // 
            this.lblDataFechamento.AutoSize = true;
            this.lblDataFechamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataFechamento.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDataFechamento.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDataFechamento.Location = new System.Drawing.Point(13, 112);
            this.lblDataFechamento.Name = "lblDataFechamento";
            this.lblDataFechamento.Size = new System.Drawing.Size(85, 17);
            this.lblDataFechamento.TabIndex = 31;
            this.lblDataFechamento.Text = "Fechamento:";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(335, 72);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(124, 23);
            this.dtpHoraInicio.TabIndex = 33;
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.CustomFormat = "HH:mm";
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFinal.Location = new System.Drawing.Point(334, 109);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(125, 23);
            this.dtpHoraFinal.TabIndex = 34;
            // 
            // TelaAluguelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::GerenciadorDeFestas.WinForms.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 286);
            this.Controls.Add(this.dtpHoraFinal);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpDataFechamento);
            this.Controls.Add(this.lblDataFechamento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaAluguelForm";
            this.Text = "Cadastro de Alugueis";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DateTimePicker dtpDataFechamento;
        private Label lblDataFechamento;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFinal;
    }
}