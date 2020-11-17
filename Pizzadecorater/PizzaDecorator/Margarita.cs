using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class Margarita : Pizza
    {
        public override double getCost()
        {
            return 50;
        }

        public override string getDescription()
        {
            return "Det er en Margarita pizza";
        }
    }
}
