using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapculateWhatVarient
{
    public class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;

        private static Pizza Create(string type)
        {
            Pizza pizza;
            if (type.Equals(PizzaConstants.CheesePizza))
                pizza = new Cheese();
            else if (type.Equals(PizzaConstants.VegeterianPizza))
                pizza = new Vegeterian();
            else
                pizza = new Chicken();
            return pizza;
        }

        public static Pizza Order(string type)
        {
            Pizza pizza = Create(type);

            Prepare();

            Cook();

            Cut();

            return pizza;
        }

        private static void Prepare()
        {
            Console.Write("preparing...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }

        private static void Cook()
        {
            Console.Write("cooking...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }

        private static void Cut()
        {
            Console.Write("cutting and boxing...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }

        public override string ToString()
        {
            return $"\n{Title}" +
                   $"\n\tPrice: {Price.ToString("C")}";
        }
    }
}
