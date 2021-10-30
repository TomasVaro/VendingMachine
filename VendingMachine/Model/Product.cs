using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public abstract class Product
    {
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
        public int Weight { get; set; }
        public int Mililiter { get; set; }
        public bool ContainsPlastic { get; set; }

        //Shows the product's price and info
        public abstract string Examine(Product product);
        //Outputs a string message how to use the product
        public abstract string Use(Product product);
    }
}
