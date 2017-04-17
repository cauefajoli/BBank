using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBank.Model
{
    class ContaCorrente : ContaModelo
    {
        public override void saque(decimal valor)
        {
            saldo = valor - saldo;
        }

    }
}
