namespace GerenciadorDeFestas.WinForms
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TemasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ItensMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TemasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPagamento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.LightCyan;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(657, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesMenuItem,
            this.TemasMenu,
            this.aluguelMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesMenuItem
            // 
            this.clientesMenuItem.Name = "clientesMenuItem";
            this.clientesMenuItem.Size = new System.Drawing.Size(115, 22);
            this.clientesMenuItem.Text = "Cliente";
            // 
            // TemasMenu
            // 
            this.TemasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItensMenuItem,
            this.TemasMenuItem});
            this.TemasMenu.Name = "TemasMenu";
            this.TemasMenu.Size = new System.Drawing.Size(115, 22);
            this.TemasMenu.Text = "Temas";
            // 
            // ItensMenuItem
            // 
            this.ItensMenuItem.Name = "ItensMenuItem";
            this.ItensMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ItensMenuItem.Text = "Itens";
            // 
            // TemasMenuItem
            // 
            this.TemasMenuItem.Name = "TemasMenuItem";
            this.TemasMenuItem.Size = new System.Drawing.Size(107, 22);
            this.TemasMenuItem.Text = "Temas";
            // 
            // aluguelMenuItem
            // 
            this.aluguelMenuItem.Name = "aluguelMenuItem";
            this.aluguelMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aluguelMenuItem.Text = "Aluguel";
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.LightCyan;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.toolStripSeparator1,
            this.btnPagamento,
            this.toolStripSeparator2,
            this.labelTipoCadastro});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolBar.Size = new System.Drawing.Size(657, 45);
            this.toolBar.TabIndex = 2;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = global::GerenciadorDeFestas.WinForms.Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(7);
            this.btnInserir.Size = new System.Drawing.Size(42, 42);
            this.btnInserir.Text = "toolStripButton1";
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::GerenciadorDeFestas.WinForms.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(7);
            this.btnEditar.Size = new System.Drawing.Size(42, 42);
            this.btnEditar.Text = "toolStripButton2";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::GerenciadorDeFestas.WinForms.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(7);
            this.btnExcluir.Size = new System.Drawing.Size(42, 42);
            this.btnExcluir.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // btnPagamento
            // 
            this.btnPagamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPagamento.Image = global::GerenciadorDeFestas.WinForms.Properties.Resources.monetization_on_FILL0_wght400_GRAD0_opsz24;
            this.btnPagamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPagamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Padding = new System.Windows.Forms.Padding(7);
            this.btnPagamento.Size = new System.Drawing.Size(42, 42);
            this.btnPagamento.Text = "toolStripButton4";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(75, 42);
            this.labelTipoCadastro.Text = "tipoCadastro";
            // 
            // panelRegistros
            // 
            this.panelRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistros.Location = new System.Drawing.Point(0, 67);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(657, 244);
            this.panelRegistros.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(657, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "[rodape]";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(52, 17);
            this.labelRodape.Text = "[rodape]";
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 336);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "TelaPrincipalForm";
            this.Text = "Form1";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesMenuItem;
        private ToolStripMenuItem TemasMenu;
        private ToolStripMenuItem ItensMenuItem;
        private ToolStripMenuItem aluguelMenuItem;
        private ToolStrip toolBar;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnPagamento;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel labelTipoCadastro;
        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private ToolStripMenuItem TemasMenuItem;
    }
}