namespace projeto7_From
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeiroArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subitemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuláriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroPessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroVeiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.formuláriosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primeiroArquivoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // primeiroArquivoToolStripMenuItem
            // 
            this.primeiroArquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subitemToolStripMenuItem});
            this.primeiroArquivoToolStripMenuItem.Name = "primeiroArquivoToolStripMenuItem";
            this.primeiroArquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.primeiroArquivoToolStripMenuItem.Text = "Primeiro Arquivo";
            // 
            // subitemToolStripMenuItem
            // 
            this.subitemToolStripMenuItem.Name = "subitemToolStripMenuItem";
            this.subitemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subitemToolStripMenuItem.Text = "Subitem";
            // 
            // formuláriosToolStripMenuItem
            // 
            this.formuláriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroPessoasToolStripMenuItem,
            this.cadastroVeiculosToolStripMenuItem});
            this.formuláriosToolStripMenuItem.Name = "formuláriosToolStripMenuItem";
            this.formuláriosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.formuláriosToolStripMenuItem.Text = "Formulários";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroPessoasToolStripMenuItem
            // 
            this.cadastroPessoasToolStripMenuItem.Name = "cadastroPessoasToolStripMenuItem";
            this.cadastroPessoasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroPessoasToolStripMenuItem.Text = "Cadastro Pessoas";
            this.cadastroPessoasToolStripMenuItem.Click += new System.EventHandler(this.cadastroPessoasToolStripMenuItem_Click);
            // 
            // cadastroVeiculosToolStripMenuItem
            // 
            this.cadastroVeiculosToolStripMenuItem.Name = "cadastroVeiculosToolStripMenuItem";
            this.cadastroVeiculosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroVeiculosToolStripMenuItem.Text = "Cadastro Veiculos";
            this.cadastroVeiculosToolStripMenuItem.Click += new System.EventHandler(this.cadastroVeiculosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primeiroArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subitemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuláriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroPessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroVeiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}