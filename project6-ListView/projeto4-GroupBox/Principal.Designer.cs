namespace projeto4_GroupBox
{
    partial class frmPincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lsvNomes = new System.Windows.Forms.ListView();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.btnRemoverPessoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 62);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(369, 62);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(450, 62);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lsvNomes
            // 
            this.lsvNomes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lsvNomes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvNomes.FullRowSelect = true;
            this.lsvNomes.GridLines = true;
            this.lsvNomes.Location = new System.Drawing.Point(25, 102);
            this.lsvNomes.MultiSelect = false;
            this.lsvNomes.Name = "lsvNomes";
            this.lsvNomes.Size = new System.Drawing.Size(500, 232);
            this.lsvNomes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvNomes.TabIndex = 4;
            this.lsvNomes.UseCompatibleStateImageBehavior = false;
            this.lsvNomes.View = System.Windows.Forms.View.Details;
            this.lsvNomes.DoubleClick += new System.EventHandler(this.lsvNomes_DoubleClick);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(263, 62);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 1;
            this.txtIdade.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdade_Validating);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(260, 46);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Idade";
            // 
            // btnRemoverPessoa
            // 
            this.btnRemoverPessoa.Image = global::projeto4_GroupBox.Properties.Resources.btnRemover;
            this.btnRemoverPessoa.Location = new System.Drawing.Point(450, 340);
            this.btnRemoverPessoa.Name = "btnRemoverPessoa";
            this.btnRemoverPessoa.Size = new System.Drawing.Size(75, 42);
            this.btnRemoverPessoa.TabIndex = 7;
            this.btnRemoverPessoa.UseVisualStyleBackColor = true;
            this.btnRemoverPessoa.Click += new System.EventHandler(this.btnRemoverPessoa_Click);
            // 
            // frmPincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 394);
            this.Controls.Add(this.btnRemoverPessoa);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lsvNomes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmPincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListView lsvNomes;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Button btnRemoverPessoa;
    }
}

