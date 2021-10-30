using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Products
{
    public class Toy : Product
    {
        public Toy(string productType, string productName, int price, string description, bool containsPlastic)
        {
            ProductType = productType;
            ProductName = productName;
            Price = price;
            Description = description;
            ContainsPlastic = containsPlastic;
        }
        //Shows the product's price and info
        public override string Examine(Product product)
        {
            string containsPlastic = product.ContainsPlastic ? "Contains plastic" : "Doesn't contain plastic";
            return $"{product.ProductName} - {product.ProductType}, {containsPlastic}, {product.Price} kr each.";
        }
        //Outputs a string message how to use the product
        public override string Use(Product product)
        {
            return $"{product.Description}";
        }
    }
}
