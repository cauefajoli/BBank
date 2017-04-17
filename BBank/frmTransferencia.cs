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
    public partial class frmTransferencia : Form
    {
        public frmTransferencia()
        {
            InitializeComponent();
        }

        private void frmTransferencia_Load(object sender, EventArgs e)
        {
            List<ContaModelo> contas = new List<ContaModelo>();
            DAO obj = new DAO();
            contas = obj.listarConta();
            foreach (ContaModelo item in contas)
            {
                cbOrigem.Items.Add(item.numero);
                cbDestino.Items.Add(item.numero);
            }
        }

        public bool validaForm()
        {
            if (cbOrigem.SelectedItem == null || cbDestino.SelectedItem == null)
            {
                MessageBox.Show("Informe a conta Origem e Destino");
                return false;
            }

            if(cbOrigem.SelectedItem.ToString() == cbDestino.SelectedItem.ToString())
            {
                MessageBox.Show("As contas Origem e Destino devem ser diferentes");
                return false;
            }

            if (txtbValor.Text == "")
            {
                MessageBox.Show("Informe o valor a ser transferido");
                return false;
            }

            return true;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                DAO obj = new DAO();
                var contaOrigem = obj.RetornaConta(cbOrigem.SelectedItem.ToString());
                var contaDestino = obj.RetornaConta(cbDestino.SelectedItem.ToString());

                if (contaOrigem.saldo < Convert.ToDecimal(txtbValor.Text))
                {
                    MessageBox.Show("Saldo Insuficiente");
                }
                else
                {
                    contaOrigem.saque(Convert.ToDecimal(txtbValor.Text));
                    contaDestino.deposito(Convert.ToDecimal(txtbValor.Text));
                    if (obj.transferir(contaOrigem, contaDestino))
                    {
                        MessageBox.Show("Transferência realizada");
                        base.Close();
                    }
                    else
                    {
                        MessageBox.Show("Transferência não realizada");
                        base.Close();
                    }
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
