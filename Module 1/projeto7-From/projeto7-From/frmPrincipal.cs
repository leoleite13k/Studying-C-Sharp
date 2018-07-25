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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas form = new frmCadPessoas();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastroVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadVeiculo form = new frmCadVeiculo();
            form.MdiParent = this;
            form.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
