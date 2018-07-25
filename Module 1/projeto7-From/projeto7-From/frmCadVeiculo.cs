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
    public partial class frmCadVeiculo : Form
    {
        public string strPlaca;
        public string strResposta;

        public frmCadVeiculo()
        {
            InitializeComponent();
        }

        private void frmCadVeiculo_Load(object sender, EventArgs e)
        {
            lblPlaca.Text = strPlaca;
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            strResposta = txtResposta.Text;
        }
    }
}
