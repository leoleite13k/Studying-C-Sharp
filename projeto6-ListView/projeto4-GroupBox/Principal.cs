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
    public partial class frmPincipal : Form
    {
        public frmPincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cmbNomes.Items.Add(txtNome.Text);
            btnLimpar_Click(btnLimpar, new EventArgs());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Nome Inválido !");
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar_Click(btnCadastrar,new EventArgs());
            }
        }
    }
}
