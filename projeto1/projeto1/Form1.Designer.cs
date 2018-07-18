namespace projeto1
{
    partial class Form1
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
            this.btnBotao1 = new System.Windows.Forms.Button();
            this.btnBotao2 = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeCopiado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBotao1
            // 
            this.btnBotao1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBotao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotao1.Location = new System.Drawing.Point(475, 12);
            this.btnBotao1.Name = "btnBotao1";
            this.btnBotao1.Size = new System.Drawing.Size(203, 99);
            this.btnBotao1.TabIndex = 0;
            this.btnBotao1.Text = "Cadastrar";
            this.btnBotao1.UseVisualStyleBackColor = false;
            this.btnBotao1.Click += new System.EventHandler(this.btnBotao1_Click);
            // 
            // btnBotao2
            // 
            this.btnBotao2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotao2.Location = new System.Drawing.Point(479, 117);
            this.btnBotao2.Name = "btnBotao2";
            this.btnBotao2.Size = new System.Drawing.Size(199, 80);
            this.btnBotao2.TabIndex = 1;
            this.btnBotao2.Text = "Limpar";
            this.btnBotao2.UseVisualStyleBackColor = true;
            this.btnBotao2.Click += new System.EventHandler(this.btnBotao2_Click);
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(457, 99);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Leonardo Leite";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeCopiado
            // 
            this.lblNomeCopiado.AutoSize = true;
            this.lblNomeCopiado.Location = new System.Drawing.Point(26, 149);
            this.lblNomeCopiado.Name = "lblNomeCopiado";
            this.lblNomeCopiado.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCopiado.TabIndex = 3;
            this.lblNomeCopiado.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 215);
            this.Controls.Add(this.lblNomeCopiado);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnBotao2);
            this.Controls.Add(this.btnBotao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBotao1;
        private System.Windows.Forms.Button btnBotao2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeCopiado;
    }
}

