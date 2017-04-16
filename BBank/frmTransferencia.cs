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
            DAL obj = new DAL();
            contas = obj.listarConta();
            foreach (ContaModelo item in contas)
            {
                cbOrigem.Items.Add(item.numero);
                cbDestino.Items.Add(item.numero);
            }
        }

        public bool validaForm()
        {
            if (cbOrigem.SelectedItem.ToString() == "" || cbDestino.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Informe a conta Origem e Destino");
                return false;
            }

            if(txtbValor.Text == "")
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
                DAL obj = new DAL();
                var contaOrigem = obj.RetornaConta(cbOrigem.SelectedItem.ToString());
                var contaDestino = obj.RetornaConta(cbDestino.SelectedItem.ToString());

            }
        }
    }
}
