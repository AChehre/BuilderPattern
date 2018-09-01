using System;

namespace TestBuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pizza = new Pizza.Builder(10)
                .Cheese(true)
                .Pepperoni(false)
                .Bacon(true)
                .Build();
            Console.WriteLine(pizza.ToString());


            Console.WriteLine("----------");


            pizza = Pizza.NewPizza(10)
                .Cheese(true)
                .Pepperoni(false)
                .Bacon(true)
                .Build();
            Console.WriteLine(pizza.ToString());


            // Absolotely you can change this example to write the builder 
            // like this(without parameters):
            // Pizza.Builder(10)
            //       .Cheese() 
            //       .Pepperoni()
            //       .Bacon()
            //       .Build();


            Console.ReadKey();
        }
    }
}