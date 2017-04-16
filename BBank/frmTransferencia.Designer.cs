namespace BBank
{
    partial class frmTransferencia
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
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.txtbValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transferência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ORIGEM";
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Location = new System.Drawing.Point(16, 78);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(121, 21);
            this.cbOrigem.TabIndex = 4;
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(152, 78);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 21);
            this.cbDestino.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESTINO";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(386, 78);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(151, 23);
            this.btnTransferir.TabIndex = 7;
            this.btnTransferir.Text = "TRANSFERIR";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // txtbValor
            // 
            this.txtbValor.Location = new System.Drawing.Point(280, 78);
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(100, 20);
            this.txtbValor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "VALOR";
            // 
            // frmTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 116);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbValor);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOrigem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBank - Transferência";
            this.Load += new System.EventHandler(this.frmTransferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOrigem;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TextBox txtbValor;
        private System.Windows.Forms.Label label4;
    }
}