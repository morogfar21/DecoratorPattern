﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class Salami : AddIngredient
    {
        private Pizza pizza_;

        public Salami(Pizza pizza) : base(pizza)
        {
            pizza_ = pizza;
        }

        public override double getCost()
        {
            return pizza_.getCost() + 10;
        }

        public override string getDescription()
        {
            return pizza_.getDescription() + ", Salami";
        }
    }
}