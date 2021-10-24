using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Products
{
    public class Toys : Product
    {
        public Toys(string productName, int price, string description)
        {
            ProductName = productName;
            Price = price;
            Description = description;
        }
    }
}
