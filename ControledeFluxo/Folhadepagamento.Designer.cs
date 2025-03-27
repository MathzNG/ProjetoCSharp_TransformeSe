namespace ControledeFluxo
{
    partial class Folhadepagamento
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.blSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cbbClub = new System.Windows.Forms.ComboBox();
            this.lblClub = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtFolhasalario = new System.Windows.Forms.TextBox();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.txtSalarioliquido = new System.Windows.Forms.TextBox();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.ckbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(54, 47);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(129, 20);
            this.dtpData.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(26, 31);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(74, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data da Folha";
            // 
            // blSalario
            // 
            this.blSalario.AutoSize = true;
            this.blSalario.Location = new System.Drawing.Point(26, 126);
            this.blSalario.Name = "blSalario";
            this.blSalario.Size = new System.Drawing.Size(39, 13);
            this.blSalario.TabIndex = 2;
            this.blSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(54, 142);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(125, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // cbbClub
            // 
            this.cbbClub.FormattingEnabled = true;
            this.cbbClub.Items.AddRange(new object[] {
            "Club A",
            "Club B",
            "Club C"});
            this.cbbClub.Location = new System.Drawing.Point(54, 296);
            this.cbbClub.Name = "cbbClub";
            this.cbbClub.Size = new System.Drawing.Size(121, 21);
            this.cbbClub.TabIndex = 4;
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(36, 276);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(72, 13);
            this.lblClub.TabIndex = 5;
            this.lblClub.Text = "Club de Lazer";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(418, 33);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(114, 27);
            this.btnCalcula.TabIndex = 6;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            // 
            // txtFolhasalario
            // 
            this.txtFolhasalario.Location = new System.Drawing.Point(418, 97);
            this.txtFolhasalario.Name = "txtFolhasalario";
            this.txtFolhasalario.Size = new System.Drawing.Size(149, 20);
            this.txtFolhasalario.TabIndex = 7;
            // 
            // txtImposto
            // 
            this.txtImposto.Location = new System.Drawing.Point(418, 175);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(149, 20);
            this.txtImposto.TabIndex = 8;
            // 
            // txtSalarioliquido
            // 
            this.txtSalarioliquido.Location = new System.Drawing.Point(418, 258);
            this.txtSalarioliquido.Name = "txtSalarioliquido";
            this.txtSalarioliquido.Size = new System.Drawing.Size(149, 20);
            this.txtSalarioliquido.TabIndex = 9;
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Location = new System.Drawing.Point(371, 83);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(83, 13);
            this.lblSalarioFolha.TabIndex = 10;
            this.lblSalarioFolha.Text = "Folha de Salário";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(371, 155);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(94, 13);
            this.lblImposto.TabIndex = 11;
            this.lblImposto.Text = "Imposto de Renda";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(371, 239);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioLiquido.TabIndex = 12;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // ckbPlanoSaude
            // 
            this.ckbPlanoSaude.AutoSize = true;
            this.ckbPlanoSaude.Location = new System.Drawing.Point(54, 210);
            this.ckbPlanoSaude.Name = "ckbPlanoSaude";
            this.ckbPlanoSaude.Size = new System.Drawing.Size(87, 17);
            this.ckbPlanoSaude.TabIndex = 13;
            this.ckbPlanoSaude.Text = "Plano Saúde";
            this.ckbPlanoSaude.UseVisualStyleBackColor = true;
            this.ckbPlanoSaude.CheckedChanged += new System.EventHandler(this.ckbPlanoSaude_CheckedChanged);
            // 
            // Folhadepagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 404);
            this.Controls.Add(this.ckbPlanoSaude);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.txtSalarioliquido);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.txtFolhasalario);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.cbbClub);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.blSalario);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Name = "Folhadepagamento";
            this.Text = "Folhadepagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label blSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cbbClub;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox txtFolhasalario;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.TextBox txtSalarioliquido;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.CheckBox ckbPlanoSaude;
    }
}