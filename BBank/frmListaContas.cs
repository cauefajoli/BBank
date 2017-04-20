using BBank.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBank
{
    public partial class frmListaContas : Form
    {
        public frmListaContas()
        {
            InitializeComponent();
        }

        private void frmListaContas_Load(object sender, EventArgs e)
        {
            DAO contas = new DAO();
            dtgContas.DataSource = contas.listarConta();
        }

        private void dtgContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditarConta editar = new frmEditarConta(dtgContas.CurrentRow.Cells[0].Value.ToString());
            editar.ShowDialog();
            DAO contas = new DAO();
            dtgContas.DataSource = contas.listarConta();
        }
    }
}
