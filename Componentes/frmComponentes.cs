using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    cbbListarnome.Items.Add(txtNome.Text);
                    txtNome.Clear();
                    txtNome.Focus();
                }
            
            

        }

        private void ckbLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLivros.Checked)
            {
                ltbListarprodutos.Items.Add("Livros");
            }
            else
            {
                ltbListarprodutos.Items.Remove(0);
            }
        }

        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbComputador.Checked)
            {
                ltbListarprodutos.Items.Add("Computador");
            }
            else
            {
                ltbListarprodutos.Items.Remove(0);
            }
        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMesa.Checked)
            {
                ltbListarprodutos.Items.Add("Mesa");
            }
            else
            {
                ltbListarprodutos.Items.Remove(0);
            }
        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBanana.Checked)
            {
                ltbListarprodutos.Items.Add("Banana");
            }
            else
            {
                ltbListarprodutos.Items.Remove(0);
            }
        }
    }
}
