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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando as variáveis

            double num1, num2, resp = 0;

            // inicializar as variáveis
            try
            {
                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);


                if (rdbSomar.Checked == false && rdbSubtrair.Checked == false && rdbMultiplicacao.Checked == false && rdbDivisao.Checked == false)
                {
                    MessageBox.Show("Favor escolher a operação!!",
                            "error",
                            MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                    LimparCampos();
                }
                else
                {

                    //Criando a estrutura de decisão
                    if (rdbSomar.Checked)
                    {
                        //somando valores
                        resp = num1 + num2;
                    }
                    if (rdbSubtrair.Checked)
                    {
                        //subtraindo valores
                        resp = num1 - num2;
                    }
                    if (rdbDivisao.Checked)
                    {
                        //Dividindo valores
                        if (num2 == 0)
                        {
                            MessageBox.Show("Impossivel dividir por 0",
                                "error",
                                MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                            LimparCampos();
                        }
                        else
                        {
                            resp = num1 / num2;
                        }
                    }
                    if (rdbMultiplicacao.Checked)
                    {
                        //Multiplicando valores
                        resp = num1 * num2;
                    }
                }

                txtReposta.Text = Convert.ToString(resp);
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir valores validos",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                LimparCampos();
            }

        }
    }
}
