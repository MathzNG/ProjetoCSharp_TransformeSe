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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if(pgbSplash.Value < 100)
            {
                pgbSplash.Value = pgbSplash.Value + 10;
                lblNumero.Text = pgbSplash.Value.ToString() + "%";
                
                
            }
            else
            {
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
                lblNumero.Enabled = false;
            }
            return;
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void pgbSplash_Click(object sender, EventArgs e)
        {
            
        }
    }
}
