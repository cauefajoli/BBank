namespace BBank
{
    partial class frmEditarConta
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
            this.txtbAgencia = new System.Windows.Forms.MaskedTextBox();
            this.txtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPoupanca = new System.Windows.Forms.RadioButton();
            this.rdCorrente = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Editar Conta";
            // 
            // txtbAgencia
            // 
            this.txtbAgencia.Location = new System.Drawing.Point(108, 89);
            this.txtbAgencia.Name = "txtbAgencia";
            this.txtbAgencia.Size = new System.Drawing.Size(137, 20);
            this.txtbAgencia.TabIndex = 22;
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(108, 58);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(137, 20);
            this.txtbNumero.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPoupanca);
            this.groupBox1.Controls.Add(this.rdCorrente);
            this.groupBox1.Location = new System.Drawing.Point(28, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 51);
            this.groupBox1.TabIndex = 25;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "AGÊNCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "NÚMERO";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(144, 233);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(101, 38);
            this.btnAtualizar.TabIndex = 28;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmEditarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 292);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtbAgencia);
            this.Controls.Add(this.txtbNumero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBank - Editar Conta";
            this.Load += new System.EventHandler(this.frmEditarConta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtbAgencia;
        private System.Windows.Forms.MaskedTextBox txtbNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPoupanca;
        private System.Windows.Forms.RadioButton rdCorrente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtualizar;
    }
}