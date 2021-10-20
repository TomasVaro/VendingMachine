using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    class VendingMachine : IVending
    {
        public string Product { get; set; }
        public int Price { get; set; }
        public string Message { get; set; }

        public VendingMachine(string product, int price, string message)
        {
            Product = product;
            Price = price;
            Message = message;
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
