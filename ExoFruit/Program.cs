using System;
using System.Collections.Generic;

namespace ExoFruit
{
    class Program
    {
        //test
        static void Main(string[] args)
        {
            bool end = false;
            List<Fruit> list = new List<Fruit>();
            while (!end)
            {
                Console.WriteLine("What do you want to add?\n1 : orange\n2 : apple\n3 : see the list\nother thing to end");
                string response = Console.ReadLine();
                if (response == "1")
                {
                    Fruit orange = new Fruit("orange");
                    list.Add(orange);
                    Console.Clear();
                }
                else if (response == "2")
                {
                    Fruit apple = new Fruit("apple");
                    list.Add(apple);
                    Console.Clear();
                }
                else if (response == "3")
                {
                    if (list == null || list.Count == 0)
                    {
                        Console.WriteLine("No article in the list");
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write($"  | {list[i].Name}");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    end = true;
                }
            }
            double totalPrice = 0;
            if (list == null || list.Count == 0)
            {

            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    totalPrice += list[i].Price;
                }
            }
            Console.WriteLine($"The scan is finished the total cost is {totalPrice}");
            Console.ReadLine();
        }
    } 
}
