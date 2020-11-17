using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDecorator
{
    class Taxes : Bankkonto
    {
        private Bankkonto bankkonto_;

        public Taxes(Bankkonto bankkonto)
        {
            bankkonto_ = bankkonto;
        }

        public override double getSaldo()
        {
            return saldo;
        }


        public override double payTaxes()
        {
            return bankkonto_.payTaxes();
        }
    }
}
