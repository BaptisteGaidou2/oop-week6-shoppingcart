using System;
using System.Collections.Generic;
using System.Text;

namespace ExoFruit
{
    class Fruit
    {
        private string name;
        private double price;
        public Fruit(string fruitName)
        {
            name = fruitName;
            switch (Name)
            {
                case "apple":
                    price = 0.6;
                    break;
                case "orange":
                    price = 0.25;
                    break;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public double Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }

    }
}
