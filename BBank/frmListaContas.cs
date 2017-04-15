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
            DAL contas = new DAL();
            dtgContas.DataSource = contas.listarConta();
        }
    }
}
