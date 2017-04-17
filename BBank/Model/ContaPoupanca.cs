using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBank.Model
{
    class ContaPoupanca : ContaModelo
    {
        public override void saque(decimal valor)
        {
            saldo = saldo - valor;
        }
    }
}
