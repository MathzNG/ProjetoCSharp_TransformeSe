using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControledeFluxo
{
    public partial class Folhadepagamento : Form
    {
        public Folhadepagamento()
        {
            InitializeComponent();
            DesabilitandoCampos();
            carregandoCombo();
        }
        public void LimparCampos()
        {
            txtSalario.Clear();
            txtSalarioliquido.Clear();
            txtImposto.Clear();
            txtFolhasalario.Clear();
            cbbClub.Text = "";
            ckbPlanoSaude.Checked = false;
            txtSalario.Focus();

        }
        public void DesabilitandoCampos()
        {
            txtFolhasalario.Enabled = false;
            txtImposto.Enabled = false;
            txtSalarioliquido.Enabled = false;
        }

        public void carregandoCombo()
        {
            cbbClub.Items.Add("Club A");
            cbbClub.Items.Add("Club B");
            cbbClub.Items.Add("Club C");
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtFolhasalario.Text = txtSalario.Text;
        }



        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double salariofolha = 0, imposto = 0, salarioliquido = 0;
            try
            {
                salariofolha = Convert.ToDouble(txtFolhasalario.Text);
                //imposto = Convert.ToDouble(txtImposto.Text);

                salarioliquido = salariofolha - imposto;

                if (salariofolha < 2259.20)
                {
                    
                    txtSalarioliquido.Text = txtFolhasalario.Text;
                }
                else if (salariofolha > 2259.21 && salariofolha <= 2826.65)
                {
                    salarioliquido = (salariofolha - (imposto));
                    imposto = salariofolha * 7.5 / 100;
                }
                else if (salariofolha > 2826.66 && salariofolha <= 3751.05)
                {
                    salarioliquido = (salariofolha - (imposto));
                    imposto = salariofolha * 15 / 100;
                }
                else if (salariofolha > 3751.06 && salariofolha <= 4664.68)
                {
                    salarioliquido = (salariofolha - (imposto));
                    imposto = salariofolha * 22.5 / 100;
                }
                else if (salariofolha > 4664.69)
                {
                    salarioliquido = (salariofolha - (imposto));
                    imposto = salariofolha * 27.5 / 100;
                }

                if (ckbPlanoSaude.Checked)
                {
                    salarioliquido = salarioliquido - 200;

                }
                if (cbbClub.SelectedIndex == 0)
                {
                    salarioliquido = salarioliquido - 100;
                }
                if (cbbClub.SelectedIndex == 1)
                {
                    salarioliquido = salarioliquido - 50;
                }
                if (cbbClub.SelectedIndex == 2)
                {
                    salarioliquido = salarioliquido - 30;
                }
            }
            catch
            {
                MessageBox.Show("Error","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                LimparCampos();
            }

            txtImposto.Text = imposto.ToString();
            txtSalarioliquido.Text = Convert.ToString(salarioliquido);
        }

       
    }
}
