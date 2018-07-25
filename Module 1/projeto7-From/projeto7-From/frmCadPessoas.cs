using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto7_From
{
    public partial class frmCadPessoas : Form
    {
        public frmCadPessoas()
        {
            InitializeComponent();
        }

        private void frmCadPessoas_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastrar PLaca";
        }

        private void frmCadPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmCadPessoas_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            frmCadVeiculo from = new frmCadVeiculo();
            from.Text = "PLacas";
            from.StartPosition = FormStartPosition.Manual;
            from.Location = new Point(100,100);
            from.strPlaca = txtPlaca.Text.Trim();
            from.ShowDialog();
            txtResposta.Text = from.txtResposta.Text;
        }
    }
}
