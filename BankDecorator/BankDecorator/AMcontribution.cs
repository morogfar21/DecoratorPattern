using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDecorator
{
    class AMcontribution : Bankkonto
    {
        private Bankkonto bankkonto_;

        public AMcontribution(Bankkonto bankkonto)
        {
            bankkonto_ = bankkonto;
        }

        public override double getSaldo()
        {
            return bankkonto_.getSaldo();
        }


        public override double payTaxes()
        {
            return bankkonto_.payTaxes()+0.08;
        }
    }
}
