namespace BBank
{
    partial class frmSaque
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtbValor = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.cbContas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "VALOR";
            // 
            // txtbValor
            // 
            this.txtbValor.Location = new System.Drawing.Point(142, 88);
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(100, 20);
            this.txtbValor.TabIndex = 20;
            this.txtbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbValor_KeyPress);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(248, 86);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(151, 23);
            this.btnSacar.TabIndex = 19;
            this.btnSacar.Text = "SACAR";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // cbContas
            // 
            this.cbContas.FormattingEnabled = true;
            this.cbContas.Location = new System.Drawing.Point(15, 88);
            this.cbContas.Name = "cbContas";
            this.cbContas.Size = new System.Drawing.Size(121, 21);
            this.cbContas.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "CONTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Saque";
            // 
            // frmSaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 122);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbValor);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.cbContas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSaque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBank - Saque";
            this.Load += new System.EventHandler(this.frmSaque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbValor;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.ComboBox cbContas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}