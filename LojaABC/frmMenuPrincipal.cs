﻿using System;
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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin voltar = new frmLogin();
            voltar.Show();
            this.Hide();
        }

        private void bntFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarios abrir = new frmFuncionarios();
            abrir.Show();
            this.Hide();   
        }
    }
}
