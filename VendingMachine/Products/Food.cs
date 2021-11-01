using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Products
{
    public class Food : Product
    {
        public int Calories { get; set; }
        public int Weight { get; set; }
        public Food(string productType,  string productName, int price, string description, int calories, int weight)
        {
            ProductType = productType;
            ProductName = productName;
            Price = price;
            Description = description;
            Calories = calories;
            Weight = weight;
        }
        //Shows the product's price and info
        public override string Examine(Product product)
        {
            return $"{product.ProductName} - {product.ProductType}, {Weight} g, {Calories} kcal, {product.Price} kr each.";
        }
        //Outputs a string message how to use the product
        public override string Use(Product product)
        {
            return $"{product.Description}";
        }
    }
}