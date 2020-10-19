using System;
using System.Collections.Generic;

namespace ExoFruit
{
    class Program
    {
        //test
        static void Main(string[] args)
        {
            Product orange = new Product("orange",0.2);
            Product apple = new Product("apple",0.4);
            List<Product> list = new List<Product> { orange, orange, apple, apple, orange };
            Checkout check = new Checkout(list);
            Console.WriteLine($"The scan is finished the total cost is {check.TotalPrice}");
            Console.ReadLine();
        }
    } 
}
