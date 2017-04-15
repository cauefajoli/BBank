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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            frmCadastrarConta cadastro = new frmCadastrarConta();
            cadastro.ShowDialog();
        }

        private void btnListarConta_Click(object sender, EventArgs e)
        {
            frmListaContas listagem = new frmListaContas();
            listagem.ShowDialog();
        }
    }
}
