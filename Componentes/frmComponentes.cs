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
                pcbImagens.Load(@".\Imagens\Livros.png");
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
                pcbImagens.Load(@".\Imagens\Computador.png");
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
                pcbImagens.Load(@".\Imagens\Mesa.png");
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
                pcbImagens.Load(@".\Imagens\Banana.png");
            }
            else
            {
                ltbListarprodutos.Items.Remove(0);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione uma imagem";
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp|Todos os arquivos|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pcbImagens.ImageLocation = ofd.FileName;
                pcbImagens.Load();
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pcbImagens.Image = null;
        }
    }
}
