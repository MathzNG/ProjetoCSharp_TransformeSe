using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importando a biblioteca do banco de dados
using MySql.Data.MySqlClient;
using MosaicoSolutions.ViaCep;
using System.Data.SqlTypes;
using System.ServiceModel.Channels;


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

        public frmFuncionarios(string descricao)
        {
            InitializeComponent();
            //desabilitar os campos
            desabilitarcampos();
            txtNome.Text = descricao;
            Habilitarcampos_pesquisar();
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
            txtBairro.Enabled = false;
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
            txtBairro.Clear();
            cbbUf.Text = "";

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
            txtBairro.Enabled = true;
            cbbUf.Enabled = true;

            //Botões
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }


        public void Habilitarcampos_pesquisar()
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
            txtBairro.Enabled = true;
            cbbUf.Enabled = true;

            //Botões
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
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

        public int CadastrarFuncionarios()
        {
            //Criando a conexão
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nome,email,cpf,dataNasc,telCel,sexo,logradouro,cep,numero,complemento,bairro,cidade,uf)values(@nome,@email,@cpf,@dataNasc,@telCel,@sexo,@logradouro,@cep,@numero,@complemento,@bairro,@cidade,@uf);";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            //Adicionando os parâmetros
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCpf.Text;
            comm.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = dtpDatanascimento.Value;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 14).Value = mskCelular.Text;
            
            comm.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = txtLogradouro.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = mskCep.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = txtComplemento.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = cbbUf.Text;

            if (rdbFeminino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "F";
            }
            if (rdbMasculino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "M";
            }
            if(rdbNãodesejoinformar.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "N";
            }


            comm.Connection = Conection.obterconexao();
            int resp = comm.ExecuteNonQuery();

            Conection.fecharconexao();
            return resp;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mskCpf.Text.Equals("   .   .   -") || mskCelular.Text.Equals("     -") || txtLogradouro.Text.Equals("") || txtNumero.Text.Equals("") || txtCidade.Text.Equals("") || txtComplemento.Text.Equals("")
                || txtBairro.Text.Equals("") || mskCep.Text.Equals("     -") || cbbUf.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!!!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (CadastrarFuncionarios() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso",
                        "Sucesso");
                    LimparCampos();
                    desabilitarcampos();
                    btnNovo.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conection.obterconexao();
            MessageBox.Show("Foi");
            Conection.fecharconexao();
            MessageBox.Show(" Não foi");

        }
        public void cadastrarfuncionario()
        {

        }

        public void BuscarCEP(string CEP)
        {
            var viaCEPService = ViaCepService.Default();
            try
            {
                var endereco = viaCEPService.ObterEndereco(CEP);

                txtLogradouro.Text = endereco.Logradouro;
                txtComplemento.Text = endereco.Complemento;
                txtCidade.Text = endereco.Localidade;
                txtBairro.Text = endereco.Unidade;
                cbbUf.Text = endereco.UF;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir um CEP valido!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCep.Focus();
                mskCep.Clear();
            }
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarCEP(mskCep.Text);
                txtNumero.Focus();
            }
        }
    }
}
