using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDecorator;

namespace PizzaDecorator
{
    class Bacon : AddIngredient
    {
        private Pizza pizza_;

        public Bacon(Pizza pizza) : base(pizza)
        {
            pizza_ = pizza;
        }

        public override double getCost()
        {
            return pizza_.getCost() + 10;
        }

        public override string getDescription()
        {
            return pizza_.getDescription() + ", Bacon";
        }
    }
}
