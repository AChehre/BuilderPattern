using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza.Builder(10)
                                    .Cheese(true)
                                    .Pepperoni(false)
                                    .Bacon(true)
                                    .Build();
            Console.WriteLine(pizza.ToString());


            Console.WriteLine("----------");


            pizza = Pizza.Create(10)
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
