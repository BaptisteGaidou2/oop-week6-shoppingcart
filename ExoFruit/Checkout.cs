using System;
using System.Collections.Generic;
using System.Text;

namespace ExoFruit
{
    class Checkout
    {
        double totalPrice;
        List<Product> listProduct;
        public Checkout(List<Product> list)
        {
            listProduct = list;
        }
        public double TotalPrice
        {
            get
            {
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
    }
}
