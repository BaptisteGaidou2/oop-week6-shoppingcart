using System;
using System.Collections.Generic;
using System.Text;

namespace ExoFruit
{
    public class Checkout : Offers
    {
        private double totalPrice;
        private List<Product> listProduct;
        public Checkout()
        {
            totalPrice = 0;
        }
        public override string ToString()
        {
            string afi = "";
            afi+=($"Total Price={TotalPrice}\nappleOffer={appleOffer}\norangeOffer={orangeOffer}\nList of product : ");
            for(int i=0;i<listProduct.Count; i++)
            {
                afi += listProduct[i].Name+"\n";
            }
            return afi;
        }
        public int numberOfOneProduct(string productName)
        {
            int number = 0;
            for(int i=0;i<listProduct.Count; i++)
            {
                if (listProduct[i].Name == productName)
                {
                    number++;
                }
            }
            return number;
        }
        public double TotalPrice
        {
            get
            {
                FreeApple();
                FreeOrange();
                if (orangeOffer)
                {
                    Product orangeFree = new Product("Free orange", 0);
                    listProduct.Add(orangeFree);
                }
                if (appleOffer)
                {
                    Product appleFree = new Product("Free apple", 0);
                    listProduct.Add(appleFree);
                }
                for (int i = 0; i < listProduct.Count; i++)
                {
                    totalPrice += listProduct[i].Price;
                }
                return totalPrice;
            }
        }
        public List<Product> ListProduct
        {
            set
            {
                listProduct = value;
            }
            get
            {
                return listProduct;
            }
        }

        public bool appleOffer { get; set; }
        public bool orangeOffer { get; set; }

        public void Add(Product item)
        {
            listProduct.Add(item);
        }

        public void FreeApple()
        {
            if (numberOfOneProduct("apple") == 1)
            {
                appleOffer = true;
            }
            else
            {
                appleOffer = false;
            }
        }

        public void FreeOrange()
        {
            if (numberOfOneProduct("orange") == 2)
            {
                orangeOffer = true;
            }
            else
            {
                orangeOffer = false;
            }
        }
    }
}
