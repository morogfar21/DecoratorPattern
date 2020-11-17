using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDecorator
{
    class Lonkonto : Bankkonto
    {
        public Lonkonto(double sum)
        {
            saldo = sum;
            tax = 0;
        }
        public override double payTaxes()
        {
            return 0;
        }

        public override double getSaldo()
        {
            saldo = saldo * (1 - this.payTaxes());
            return saldo;
        }

    }
}
