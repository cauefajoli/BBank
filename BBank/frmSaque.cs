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
    public partial class frmSaque : Form
    {
        public frmSaque()
        {
            InitializeComponent();
        }

        private void frmSaque_Load(object sender, EventArgs e)
        {
            List<ContaModelo> contas = new List<ContaModelo>();
            DAO obj = new DAO();
            contas = obj.listarConta();
            foreach (ContaModelo item in contas)
            {
                cbContas.Items.Add(item.numero);
            }
        }

        public bool validaForm()
        {
            if (cbContas.SelectedItem == null)
            {
                MessageBox.Show("Selecione a conta");
                return false;
            }


            if (cbContas.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Selecione a conta");
                return false;
            }

            if (txtbValor.Text == "")
            {
                MessageBox.Show("Informe o valor");
                return false;
            }

            return true;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                DAO obj = new DAO();
                var conta = obj.RetornaConta(cbContas.SelectedItem.ToString());
                if(conta.saldo >= Convert.ToDecimal(txtbValor.Text))
                {
                    conta.saque(Convert.ToDecimal(txtbValor.Text));
                    if (obj.atualizarSaldo(conta))
                    {
                        MessageBox.Show("Saque realizado");
                        base.Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha no saque");
                    }
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }
                
            }
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
