using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBank.Model
{
    class ContaModelo
    {
        public char tipo { get; set; }
        public string agencia { get; set; }
        public string numero { get; set; }
        public decimal saldo { get; set; }

        public virtual void saque(decimal valor)
        {
            saldo -= valor;

        }

        public void deposito()
        {

        }

        public void transferencia()
        {

        }
    }
}
