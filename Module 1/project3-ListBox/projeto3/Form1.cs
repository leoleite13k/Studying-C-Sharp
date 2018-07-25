using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto3
{
    public partial class Form1 : Form
    {
        private int iSelecionado;

        public Form1()
        {
            InitializeComponent();
            iSelecionado = -1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (iSelecionado > -1)
            {
                lsbNome.Items[iSelecionado] = txtNome.Text;
                ordenar();
                btnLimpar_Click(btnLimpar, new EventArgs());
                iSelecionado = -1;
                btnCadastrar.Text = "Cadastrar";
                return;
            }
            lsbNome.Items.Add(txtNome.Text);
            ordenar();
            btnLimpar_Click(btnLimpar, new EventArgs());
            // ou  txtNome.Text = String.Empty;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
        }

        private void lsbNome_DoubleClick(object sender, EventArgs e)
        {
            iSelecionado = lsbNome.SelectedIndex;
            txtNome.Text = lsbNome.Items[iSelecionado].ToString();
            btnCadastrar.Text = "Alterar";
            //Remover item do List Box
            //int index = lsbNome.SelectedIndex;
            //lsbNome.Items.RemoveAt(index);

        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Nome Invalido");
            }
        }

        private void ordenar()
        {
            ListBox.ObjectCollection lista = lsbNome.Items;
            List<string> listaString = new List<string>();
            foreach (var item in lista)
            {
                listaString.Add(item.ToString());
            }
            listaString = (from s in listaString select s).OrderBy(x =>x).ToList();
            lsbNome.Items.Clear();
            foreach(var item in listaString)
            {
                lsbNome.Items.Add(item);
            }
        }
    }
}
