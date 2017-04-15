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
    public partial class frmEncerrarConta : Form
    {
        public frmEncerrarConta()
        {
            InitializeComponent();
        }

        private void frmEncerrarConta_Load(object sender, EventArgs e)
        {
            List<ContaModelo> contas = new List<ContaModelo>();
            DAL obj = new DAL();
            contas = obj.listarConta();
            foreach (ContaModelo item in contas)
            {
                cbContas.Items.Add(item.numero);
            }
        }

        private void btnEncerrarConta_Click(object sender, EventArgs e)
        {
            String conta = cbContas.SelectedItem.ToString();
            DAL obj = new DAL();
            if (obj.encerrarConta(conta))
            {
                MessageBox.Show("Conta Encerrada");
                base.Close();
            }
            else
            {
                MessageBox.Show("Operação não realizada");
                base.Close();
            }
        }
    }
}
