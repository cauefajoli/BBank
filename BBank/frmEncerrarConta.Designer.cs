namespace BBank
{
    partial class frmEncerrarConta
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
            this.cbContas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncerrarConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbContas
            // 
            this.cbContas.FormattingEnabled = true;
            this.cbContas.Location = new System.Drawing.Point(81, 54);
            this.cbContas.Name = "cbContas";
            this.cbContas.Size = new System.Drawing.Size(223, 21);
            this.cbContas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encerrar Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTA";
            // 
            // btnEncerrarConta
            // 
            this.btnEncerrarConta.BackColor = System.Drawing.Color.Brown;
            this.btnEncerrarConta.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEncerrarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarConta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEncerrarConta.Location = new System.Drawing.Point(12, 91);
            this.btnEncerrarConta.Name = "btnEncerrarConta";
            this.btnEncerrarConta.Size = new System.Drawing.Size(292, 38);
            this.btnEncerrarConta.TabIndex = 3;
            this.btnEncerrarConta.Text = "ENCERRAR";
            this.btnEncerrarConta.UseVisualStyleBackColor = false;
            this.btnEncerrarConta.Click += new System.EventHandler(this.btnEncerrarConta_Click);
            // 
            // frmEncerrarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 142);
            this.Controls.Add(this.btnEncerrarConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbContas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEncerrarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBank - Encerrar Conta";
            this.Load += new System.EventHandler(this.frmEncerrarConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbContas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncerrarConta;
    }
}