using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Products
{
    public class Drink : Product
    {
        public Drink(string productType, string productName, int price, string description, int mililiter)
        {
            ProductType = productType;
            ProductName = productName;
            Price = price;
            Description = description;
            Mililiter = mililiter;
        }
        //Shows the product's price and info
        public override string Examine(Product product)
        {
            return $"{product.ProductName} - {product.ProductType}, {product.Mililiter} ml, {product.Price} kr each.";
        }
        //Outputs a string message how to use the product
        public override string Use(Product product)
        {
            return $"{product.Description}";
        }
    }
}
