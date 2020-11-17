using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankkonto konto = new Lonkonto(30000);
            konto = new AMcontribution(konto);
            konto = new AMcontribution(konto);

            Console.WriteLine(konto.getSaldo());
        }
    }
}
