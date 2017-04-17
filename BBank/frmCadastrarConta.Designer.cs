namespace BBank
{
    partial class frmCadastrarConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPoupanca = new System.Windows.Forms.RadioButton();
            this.rdCorrente = new System.Windows.Forms.RadioButton();
            this.txtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtbAgencia = new System.Windows.Forms.MaskedTextBox();
            this.txtbSaldo = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NÚMERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "AGÊNCIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "SALDO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPoupanca);
            this.groupBox1.Controls.Add(this.rdCorrente);
            this.groupBox1.Location = new System.Drawing.Point(29, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO";
            // 
            // rdPoupanca
            // 
            this.rdPoupanca.AutoSize = true;
            this.rdPoupanca.Location = new System.Drawing.Point(107, 20);
            this.rdPoupanca.Name = "rdPoupanca";
            this.rdPoupanca.Size = new System.Drawing.Size(84, 17);
            this.rdPoupanca.TabIndex = 5;
            this.rdPoupanca.TabStop = true;
            this.rdPoupanca.Text = "POUPANÇA";
            this.rdPoupanca.UseVisualStyleBackColor = true;
            // 
            // rdCorrente
            // 
            this.rdCorrente.AutoSize = true;
            this.rdCorrente.Location = new System.Drawing.Point(16, 20);
            this.rdCorrente.Name = "rdCorrente";
            this.rdCorrente.Size = new System.Drawing.Size(85, 17);
            this.rdCorrente.TabIndex = 4;
            this.rdCorrente.TabStop = true;
            this.rdCorrente.Text = "CORRENTE";
            this.rdCorrente.UseVisualStyleBackColor = true;
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(109, 68);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(137, 20);
            this.txtbNumero.TabIndex = 0;
            // 
            // txtbAgencia
            // 
            this.txtbAgencia.Location = new System.Drawing.Point(109, 99);
            this.txtbAgencia.Name = "txtbAgencia";
            this.txtbAgencia.Size = new System.Drawing.Size(137, 20);
            this.txtbAgencia.TabIndex = 1;
            // 
            // txtbSaldo
            // 
            this.txtbSaldo.Location = new System.Drawing.Point(108, 129);
            this.txtbSaldo.Name = "txtbSaldo";
            this.txtbSaldo.Size = new System.Drawing.Size(138, 20);
            this.txtbSaldo.TabIndex = 2;
            this.txtbSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbSaldo_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(145, 236);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 38);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCadastrarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 286);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtbSaldo);
            this.Controls.Add(this.txtbAgencia);
            this.Controls.Add(this.txtbNumero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBank - Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPoupanca;
        private System.Windows.Forms.RadioButton rdCorrente;
        private System.Windows.Forms.MaskedTextBox txtbNumero;
        private System.Windows.Forms.MaskedTextBox txtbAgencia;
        private System.Windows.Forms.MaskedTextBox txtbSaldo;
        private System.Windows.Forms.Button btnCadastrar;
    }
}