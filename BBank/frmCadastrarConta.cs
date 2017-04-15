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
    public partial class frmCadastrarConta : Form
    {
        public frmCadastrarConta()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validarForm())
            {
                ContaModelo conta = new ContaModelo();
                conta.numero = txtbNumero.Text;
                conta.agencia = txtbAgencia.Text;
                txtbSaldo.Text.Replace(",", ".");
                conta.saldo = Convert.ToDecimal((txtbSaldo.Text.Equals("") ? "0.00" : txtbSaldo.Text));
                if (rdCorrente.Checked)
                    conta.tipo = 'C';
                else
                    conta.tipo = 'P';

                DAL op = new DAL();
                if (op.cadastrarConta(conta))
                    MessageBox.Show("Conta Cadastrada");
                else
                    MessageBox.Show("Falha no Cadastro");

                base.Close();
            }
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
    }
}
