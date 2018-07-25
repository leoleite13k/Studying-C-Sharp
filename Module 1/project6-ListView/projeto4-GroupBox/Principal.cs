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
        private int iSelecionado = -1;

        public frmPincipal()
        {
            InitializeComponent();
            carregaLista();
        }

        private void carregaLista()
        {
            lsvNomes.Clear();
            lsvNomes.Columns.Insert(0,"Nome", 250,HorizontalAlignment.Left);
            lsvNomes.Columns.Insert(1,"Idade",100, HorizontalAlignment.Right);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (iSelecionado > -1)
            {
                lsvNomes.Items[iSelecionado].SubItems[0].Text = txtNome.Text;
                lsvNomes.Items[iSelecionado].SubItems[1].Text = txtIdade.Text;
                iSelecionado = -1;
                btnCadastrar.Text = "Cadastrar";
                txtNome.Text = String.Empty;
                txtIdade.Text = String.Empty;
                return;
            }
            ListViewItem lista = lsvNomes.Items.Add(txtNome.Text.Trim());
            lista.SubItems.Add(new ListViewItem.ListViewSubItem(null,txtIdade.Text.Trim()));
            txtNome.Text = String.Empty;
            txtIdade.Text = String.Empty;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtIdade.Text = String.Empty;
            lsvNomes.Items.Clear();
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Nome Inválido !");
                txtNome.Focus();
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCadastrar_Click(btnCadastrar, new EventArgs());
            }
        }

        private void txtIdade_Validating(object sender, CancelEventArgs e)
        {
            if (txtIdade.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Idade Inválida !");
                txtIdade.Focus();
            }
        }

        private void btnRemoverPessoa_Click(object sender, EventArgs e)
        {
            if (lsvNomes.SelectedIndices.Count < 1)
            {
                MessageBox.Show("Nenhuma Pessoas Selecionada!");
                return;
            }
            int iPosicao = lsvNomes.SelectedIndices[0];
            lsvNomes.Items.RemoveAt(iPosicao);
        }

        private void lsvNomes_DoubleClick(object sender, EventArgs e)
        {
            if (lsvNomes.SelectedIndices.Count < 1) return;
            iSelecionado = lsvNomes.SelectedIndices[0];
            txtNome.Text = lsvNomes.Items[iSelecionado].SubItems[0].Text;
            txtIdade.Text = lsvNomes.Items[iSelecionado].SubItems[1].Text;
            btnCadastrar.Text = "Alterar";
        }
    }
}
