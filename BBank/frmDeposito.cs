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
    public partial class frmDeposito : Form
    {
        public frmDeposito()
        {
            InitializeComponent();
        }

        private void frmDeposito_Load(object sender, EventArgs e)
        {
            List<ContaModelo> contas = new List<ContaModelo>();
            DAO obj = new DAO();
            contas = obj.listarConta();
            foreach (ContaModelo item in contas)
            {
                cbContas.Items.Add(item.numero);
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                DAO obj = new DAO();
                var conta = obj.RetornaConta(cbContas.SelectedItem.ToString());
                conta.deposito(Convert.ToDecimal(txtbValor.Text));
                if (obj.atualizarSaldo(conta))
                {
                    MessageBox.Show("Depósito realizado");
                    base.Close();
                }
                else
                {
                    MessageBox.Show("Falha no depósito");
                }
            }
            
        }

        public bool validaForm()
        {
            if(cbContas.SelectedItem == null)
            {
                MessageBox.Show("Selecione a conta");
                return false;
            }

            if(cbContas.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Selecione a conta");
                return false;
            }

            if(txtbValor.Text == "")
            {
                MessageBox.Show("Informe o valor");
                return false;
            }

            return true;
        }

        private void txtbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
