using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        public void LimparCampos()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtReposta.Clear();
            rdbDivisao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            txtNumero1.Focus();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
