using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class AddIngredient : Pizza
    {
        private Pizza pizza_;

        public AddIngredient(Pizza pizza)
        {
            pizza_ = pizza;
        }
        public override double getCost()
        {
            return pizza_.getCost();
        }

        public override string getDescription()
        {
            return pizza_.getDescription();
        }
    }
}
