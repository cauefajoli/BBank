namespace BBank
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnCadastrarConta = new System.Windows.Forms.Button();
            this.btnEncerrarConta = new System.Windows.Forms.Button();
            this.btnListarConta = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarConta.Location = new System.Drawing.Point(12, 136);
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(247, 64);
            this.btnCadastrarConta.TabIndex = 0;
            this.btnCadastrarConta.Text = "CADASTRAR CONTA";
            this.btnCadastrarConta.UseVisualStyleBackColor = true;
            this.btnCadastrarConta.Click += new System.EventHandler(this.btnCadastrarConta_Click);
            // 
            // btnEncerrarConta
            // 
            this.btnEncerrarConta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarConta.Location = new System.Drawing.Point(12, 206);
            this.btnEncerrarConta.Name = "btnEncerrarConta";
            this.btnEncerrarConta.Size = new System.Drawing.Size(247, 64);
            this.btnEncerrarConta.TabIndex = 1;
            this.btnEncerrarConta.Text = "ENCERRAR CONTA";
            this.btnEncerrarConta.UseVisualStyleBackColor = true;
            // 
            // btnListarConta
            // 
            this.btnListarConta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarConta.Location = new System.Drawing.Point(12, 276);
            this.btnListarConta.Name = "btnListarConta";
            this.btnListarConta.Size = new System.Drawing.Size(247, 64);
            this.btnListarConta.TabIndex = 2;
            this.btnListarConta.Text = "LISTAR CONTAS";
            this.btnListarConta.UseVisualStyleBackColor = true;
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(329, 136);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(247, 64);
            this.btnDeposito.TabIndex = 3;
            this.btnDeposito.Text = "DEPÓSITO";
            this.btnDeposito.UseVisualStyleBackColor = true;
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(329, 206);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(247, 64);
            this.btnSaque.TabIndex = 4;
            this.btnSaque.Text = "SAQUE";
            this.btnSaque.UseVisualStyleBackColor = true;
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencia.Location = new System.Drawing.Point(329, 276);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(247, 64);
            this.btnTransferencia.TabIndex = 5;
            this.btnTransferencia.Text = "TRANSFERÊNCIA";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnListarConta);
            this.Controls.Add(this.btnEncerrarConta);
            this.Controls.Add(this.btnCadastrarConta);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBank - Gestão Bancária";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarConta;
        private System.Windows.Forms.Button btnEncerrarConta;
        private System.Windows.Forms.Button btnListarConta;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

