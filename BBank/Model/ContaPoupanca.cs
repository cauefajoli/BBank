using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBank.Model
{
    class ContaPoupanca : ContaModelo
    {
        public override decimal saque(decimal valor)
        {
            return base.saque((saldo - valor) - 0,1);
        }
    }
}
