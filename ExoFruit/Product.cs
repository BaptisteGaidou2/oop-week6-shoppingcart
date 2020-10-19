using System;
using System.Collections.Generic;
using System.Text;

namespace ExoFruit
{
    class Product
    {
        private string name;
        private double price;
        public Product(string fruitName,double fruitPrice)
        {
            name = fruitName;           
            price = fruitPrice;
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
