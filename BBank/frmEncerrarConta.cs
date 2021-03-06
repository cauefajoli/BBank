﻿using BBank.Model;
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
            DAO obj = new DAO();
            contas = obj.listarConta();
            foreach (ContaModelo item in contas)
            {
                cbContas.Items.Add(item.numero);
            }
        }

        private void btnEncerrarConta_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                String conta = cbContas.SelectedItem.ToString();
                DAO obj = new DAO();
                if (obj.encerrarConta(conta))
                {
                    MessageBox.Show("Conta Encerrada");
                    base.Close();
                }
                else
                {
                    MessageBox.Show("Operação não realizada, conta com saldo");
                    base.Close();
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

            if (cbContas.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Selecione a conta");
                return false;
            }

            return true;
        }
    }
}
