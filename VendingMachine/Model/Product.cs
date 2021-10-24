using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public abstract class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        TheVendingMachine vendingMachine = new TheVendingMachine();

        //Examine should show the product's price and info
        public virtual string Examine() 
        {
            return $"Product: {ProductName}\tPrice: {Price}\t Description: {Description}";
        }

        //'Use' outputs a string message how to use the product
        public virtual string Use()
        {
            return Description;
        }
    }
}
