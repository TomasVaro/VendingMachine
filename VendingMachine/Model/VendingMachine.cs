using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public class VendingMachine : IVending
    {
        public string Product { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public VendingMachine(string product, int price, string description)
        {
            Product = product;
            Price = price;
            Description = description;
        }        

        public void Purchase()
        {
            //To buy a product
        }
        public void ShowAll()
        {
            //Show all products
        }
        public void InserMoney()
        {
            //Add money to MoneyPool
        }
        public void EndTransaction()
        {
            //Returns money left in appropriate amount of change
        }
    }
}
