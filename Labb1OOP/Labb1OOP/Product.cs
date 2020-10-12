using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1OOP
{
    public class Product
    {
        public string productName { get; set; }

        public int price { get; set; }

        public Product(string ProductName, int Price)
        {

            productName = ProductName;
            price = Price;

        }
    }
}
