using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDecorator;

namespace PizzaDecorator
{
    class Garlic: AddIngredient
    {
        private Pizza pizza_;

        public Garlic(Pizza pizza) : base(pizza)
        {
            pizza_ = pizza;
        }

        public override double getCost()
        {
            return pizza_.getCost() + 5;
        }

        public override string getDescription()
        {
            return pizza_.getDescription() + ", Garlic";
        }
    }
}