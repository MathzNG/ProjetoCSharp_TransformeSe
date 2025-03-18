using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaABC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //declarando as variáveis do tipo string
            string usuario, senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (usuario.Equals("senac") && senha.Equals("12345"))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha está incorreto",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                //Chamando um método limparcampos()
                limparcampos();
            }
        }
        //Limpando campos
        public void limparcampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus(); 
            }

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();                     
            }
        }
    }
}
