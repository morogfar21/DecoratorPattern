using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDecorator
{
    abstract class Bankkonto
    {
        protected double saldo;
        protected double tax;

        public abstract double payTaxes();
        public abstract double getSaldo();
        
    }
}
