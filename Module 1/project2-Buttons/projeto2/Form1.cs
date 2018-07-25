using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblNome.Text = txtNome.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNome.Text = String.Empty;
            txtNome.Text = String.Empty;
        }
    }
}
