using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza mar = new Margarita();
            mar = new Tomatoes(mar);
            mar = new Anchovies(mar);

            /*Pizza p1 = new  Margarita();
            p1 = new Ham(p1);
            p1 = new Tomatoes(p1);
            p1 = new Dressing(p1);
            p1 = new Garlic(p1);
            */

            for (int i = 0; i < 36000; i++)
            {
                mar = new Anchovies(mar);
            }

            // Margarita
            Console.WriteLine(mar.getCost());
            Console.WriteLine(mar.getDescription());

            // Pizza 1
            //Console.WriteLine(p1.getCost());
            //Console.WriteLine(p1.getDescription());
        }
    }
}
