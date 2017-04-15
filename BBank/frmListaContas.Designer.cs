namespace BBank
{
    partial class frmListaContas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgContas = new System.Windows.Forms.DataGridView();
            this.agenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaCorrenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgContas
            // 
            this.dtgContas.AllowUserToAddRows = false;
            this.dtgContas.AllowUserToDeleteRows = false;
            this.dtgContas.AutoGenerateColumns = false;
            this.dtgContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agenciaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn});
            this.dtgContas.DataSource = this.contaCorrenteBindingSource;
            this.dtgContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgContas.Location = new System.Drawing.Point(0, 0);
            this.dtgContas.Name = "dtgContas";
            this.dtgContas.ReadOnly = true;
            this.dtgContas.Size = new System.Drawing.Size(644, 306);
            this.dtgContas.TabIndex = 0;
            // 
            // agenciaDataGridViewTextBoxColumn
            // 
            this.agenciaDataGridViewTextBoxColumn.DataPropertyName = "agencia";
            this.agenciaDataGridViewTextBoxColumn.HeaderText = "agencia";
            this.agenciaDataGridViewTextBoxColumn.Name = "agenciaDataGridViewTextBoxColumn";
            this.agenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.agenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 150;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.saldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDataGridViewTextBoxColumn.Width = 150;
            // 
            // contaCorrenteBindingSource
            // 
            this.contaCorrenteBindingSource.DataSource = typeof(BBank.Model.ContaCorrente);
            // 
            // frmListaContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 306);
            this.Controls.Add(this.dtgContas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBank - Lista Contas";
            this.Load += new System.EventHandler(this.frmListaContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgContas;
        private System.Windows.Forms.BindingSource contaCorrenteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
    }
}