using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto4_GroupBox
{
    public partial class frmRadioButtom : Form
    {
        public frmRadioButtom()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbNao.Checked = true;
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
            {
                MessageBox.Show("Sim");
            }
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNao.Checked)
            {
                MessageBox.Show("Não");
            }
        }
    }
}
