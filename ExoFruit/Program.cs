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
            Product banana = new Product("banana", 0.15);
            Product chair = new Product("chair", 25);
            Checkout check = new Checkout();
            check.ListProduct= new List<Product> { apple,orange};
            check.Add(orange);
            check.Add(chair);
            Console.WriteLine(check.ToString());
            Console.ReadLine();
        }
    } 
}
