namespace Componentes
{
    partial class frmComponentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.gpbComponentes = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblListarprodutos = new System.Windows.Forms.Label();
            this.ltbListarprodutos = new System.Windows.Forms.ListBox();
            this.lblListarnome = new System.Windows.Forms.Label();
            this.cbbListarnome = new System.Windows.Forms.ComboBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.ckbComputador = new System.Windows.Forms.CheckBox();
            this.ckbMesa = new System.Windows.Forms.CheckBox();
            this.ckbBanana = new System.Windows.Forms.CheckBox();
            this.pcbImagens = new System.Windows.Forms.PictureBox();
            this.gpbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbComponentes
            // 
            this.gpbComponentes.Controls.Add(this.pcbImagens);
            this.gpbComponentes.Controls.Add(this.cbbListarnome);
            this.gpbComponentes.Controls.Add(this.lblListarnome);
            this.gpbComponentes.Controls.Add(this.ltbListarprodutos);
            this.gpbComponentes.Controls.Add(this.lblListarprodutos);
            this.gpbComponentes.Controls.Add(this.txtNome);
            this.gpbComponentes.Controls.Add(this.lblName);
            this.gpbComponentes.Location = new System.Drawing.Point(12, 12);
            this.gpbComponentes.Name = "gpbComponentes";
            this.gpbComponentes.Size = new System.Drawing.Size(571, 387);
            this.gpbComponentes.TabIndex = 0;
            this.gpbComponentes.TabStop = false;
            this.gpbComponentes.Text = "Componentes";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 71);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(169, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblListarprodutos
            // 
            this.lblListarprodutos.AutoSize = true;
            this.lblListarprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarprodutos.Location = new System.Drawing.Point(249, 34);
            this.lblListarprodutos.Name = "lblListarprodutos";
            this.lblListarprodutos.Size = new System.Drawing.Size(95, 16);
            this.lblListarprodutos.TabIndex = 2;
            this.lblListarprodutos.Text = "Listar produtos";
            // 
            // ltbListarprodutos
            // 
            this.ltbListarprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListarprodutos.FormattingEnabled = true;
            this.ltbListarprodutos.ItemHeight = 16;
            this.ltbListarprodutos.Location = new System.Drawing.Point(245, 52);
            this.ltbListarprodutos.Name = "ltbListarprodutos";
            this.ltbListarprodutos.Size = new System.Drawing.Size(254, 132);
            this.ltbListarprodutos.TabIndex = 3;
            // 
            // lblListarnome
            // 
            this.lblListarnome.AutoSize = true;
            this.lblListarnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarnome.Location = new System.Drawing.Point(26, 123);
            this.lblListarnome.Name = "lblListarnome";
            this.lblListarnome.Size = new System.Drawing.Size(76, 16);
            this.lblListarnome.TabIndex = 4;
            this.lblListarnome.Text = "Listar nome";
            // 
            // cbbListarnome
            // 
            this.cbbListarnome.FormattingEnabled = true;
            this.cbbListarnome.Location = new System.Drawing.Point(25, 147);
            this.cbbListarnome.Name = "cbbListarnome";
            this.cbbListarnome.Size = new System.Drawing.Size(121, 21);
            this.cbbListarnome.TabIndex = 2;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(34, 257);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(45, 13);
            this.lblEscolha.TabIndex = 1;
            this.lblEscolha.Text = "Escolha";
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Location = new System.Drawing.Point(36, 287);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(54, 17);
            this.ckbLivros.TabIndex = 4;
            this.ckbLivros.Text = "Livros";
            this.ckbLivros.UseVisualStyleBackColor = true;
            this.ckbLivros.CheckedChanged += new System.EventHandler(this.ckbLivros_CheckedChanged);
            // 
            // ckbComputador
            // 
            this.ckbComputador.AutoSize = true;
            this.ckbComputador.Location = new System.Drawing.Point(36, 310);
            this.ckbComputador.Name = "ckbComputador";
            this.ckbComputador.Size = new System.Drawing.Size(83, 17);
            this.ckbComputador.TabIndex = 5;
            this.ckbComputador.Text = "Computador";
            this.ckbComputador.UseVisualStyleBackColor = true;
            this.ckbComputador.CheckedChanged += new System.EventHandler(this.ckbComputador_CheckedChanged);
            // 
            // ckbMesa
            // 
            this.ckbMesa.AutoSize = true;
            this.ckbMesa.Location = new System.Drawing.Point(36, 333);
            this.ckbMesa.Name = "ckbMesa";
            this.ckbMesa.Size = new System.Drawing.Size(52, 17);
            this.ckbMesa.TabIndex = 6;
            this.ckbMesa.Text = "Mesa";
            this.ckbMesa.UseVisualStyleBackColor = true;
            this.ckbMesa.CheckedChanged += new System.EventHandler(this.ckbMesa_CheckedChanged);
            // 
            // ckbBanana
            // 
            this.ckbBanana.AutoSize = true;
            this.ckbBanana.Location = new System.Drawing.Point(36, 356);
            this.ckbBanana.Name = "ckbBanana";
            this.ckbBanana.Size = new System.Drawing.Size(63, 17);
            this.ckbBanana.TabIndex = 7;
            this.ckbBanana.Text = "Banana";
            this.ckbBanana.UseVisualStyleBackColor = true;
            this.ckbBanana.CheckedChanged += new System.EventHandler(this.ckbBanana_CheckedChanged);
            // 
            // pcbImagens
            // 
            this.pcbImagens.Location = new System.Drawing.Point(245, 208);
            this.pcbImagens.Name = "pcbImagens";
            this.pcbImagens.Size = new System.Drawing.Size(254, 154);
            this.pcbImagens.TabIndex = 5;
            this.pcbImagens.TabStop = false;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.ckbBanana);
            this.Controls.Add(this.ckbMesa);
            this.Controls.Add(this.ckbComputador);
            this.Controls.Add(this.ckbLivros);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.gpbComponentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComponentes";
            this.gpbComponentes.ResumeLayout(false);
            this.gpbComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbComponentes;
        private System.Windows.Forms.ComboBox cbbListarnome;
        private System.Windows.Forms.Label lblListarnome;
        private System.Windows.Forms.ListBox ltbListarprodutos;
        private System.Windows.Forms.Label lblListarprodutos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.CheckBox ckbComputador;
        private System.Windows.Forms.CheckBox ckbMesa;
        private System.Windows.Forms.CheckBox ckbBanana;
        private System.Windows.Forms.PictureBox pcbImagens;
    }
}