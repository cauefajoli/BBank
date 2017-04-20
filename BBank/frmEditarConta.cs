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
    public partial class frmEditarConta : Form
    {
        string numeroConta;
        public frmEditarConta(String numero)
        {
            InitializeComponent();
            numeroConta = numero;
        }

        private bool validarForm()
        {
            if (txtbNumero.Text == "")
            {
                MessageBox.Show("Digite o número da conta");
                return false;
            }

            if (txtbAgencia.Text == "")
            {
                MessageBox.Show("Digite o número da agência");
                return false;
            }

            if (!rdCorrente.Checked && !rdPoupanca.Checked)
            {
                MessageBox.Show("Selecione o tipo de conta");
                return false;
            }
            return true;
        }

        private void txtbSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && ((sender as MaskedTextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (validarForm())
            {
                ContaModelo conta = new ContaModelo();
                conta.numero = txtbNumero.Text;
                conta.agencia = txtbAgencia.Text;
                if (rdCorrente.Checked)
                    conta.tipo = 'C';
                else
                    conta.tipo = 'P';

                DAO op = new DAO();
                if (op.atualizarConta(conta,numeroConta))
                    MessageBox.Show("Conta Atualizada");
                else
                    MessageBox.Show("Falha na atualização");

                base.Close();
            }
        }

        private void frmEditarConta_Load(object sender, EventArgs e)
        {
            ContaModelo conta = new ContaModelo();
            DAO banco = new DAO();
            conta = banco.RetornaConta(numeroConta);
            txtbNumero.Text = conta.numero.ToString();
            txtbAgencia.Text = conta.agencia.ToString();
            if (conta.tipo == 'C')
                rdCorrente.Select();
            else
                rdPoupanca.Select();
        }
    }
}
