using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    abstract class Pizza
    {
        public abstract double getCost();
        public abstract string getDescription();
    }
}
