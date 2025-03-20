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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            //desabilitar os campos
            desabilitarcampos();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        //Desabilitando os componentes
        public void desabilitarcampos()
        {
            //Dados pessoais
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCpf.Enabled = false;
            dtpDatanascimento.Enabled = false;
            mskCelular.Enabled = false;
            mskCep.Enabled = false;

            //Endereço
            gpbDadospessoais.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtComplemento.Enabled = false;
            txtEstado.Enabled = false;
            cbbUf.Enabled = false;

            //Botões
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void LimparCampos()
        {
            //Dados pessoais
            txtNome.Clear();
            txtEmail.Clear();
            mskCpf.Clear();
            dtpDatanascimento.Text = "";
            mskCelular.Clear();
            mskCep.Clear();

            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            rdbNãodesejoinformar.Checked = false;

            //Endereço
            gpbDadospessoais.Enabled = true;
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEstado.Clear();
            cbbUf.Items.Clear();

            //Botões
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }
        public void Habilitarcampos()
        {
            //Dados pessoais
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCpf.Enabled = true;
            dtpDatanascimento.Enabled = true;
            mskCelular.Enabled = true;
            mskCep.Enabled = true;

            //Endereço
            gpbDadospessoais.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            txtEstado.Enabled = true;
            cbbUf.Enabled = true;

            //Botões
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Executando habilitar campos
            Habilitarcampos();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mskCpf.Text.Equals("   .   .   -") || mskCelular.Text.Equals("     -") || txtLogradouro.Text.Equals("") || txtNumero.Text.Equals("") || txtCidade.Text.Equals("") || txtComplemento.Text.Equals("")
                || txtEstado.Text.Equals("") || mskCep.Text.Equals("     -") || cbbUf.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!!!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso",
                    "Sucesso");
                LimparCampos();
                desabilitarcampos();
            }
        }
    }
}
