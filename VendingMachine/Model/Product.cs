using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    abstract class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Product(string productName, int price, string description)
        {
            ProductName = productName;
            Price = price;
            Description = description;
        }

        //Examine should show the product's price and info
        public abstract void Examine();
        //'Use' outputs a string message how to use the product
        public abstract void Use();
    }
}
