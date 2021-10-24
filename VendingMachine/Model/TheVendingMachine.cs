using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Products;

namespace VendingMachine.Model
{
    public class TheVendingMachine : IVending
    {
        public static readonly int[] denominations = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        public int TotalCost { get; set; }
        public string Exchange { get; set; }
        public static List<Product> allProducts = new List<Product>();
        public List<Product> AllProducts { get { return allProducts; } }

        public string welcomeInfo()
        {
            return "Welcome to Vending Machine\n";
        }

        public void Purchase()
        {
            //To buy a product
        }

        //Show all products
        public void ShowAll()
        {
            TheVendingMachine vendingMachine = new TheVendingMachine();
            foreach (Product products in vendingMachine.AllProducts)
            {
                Console.WriteLine(products.ProductName + "\t" + products.Price + " kr\t" + products.Description);
            }
        }

        public Dictionary<int, int> InserMoney(int moneyAdded)
        {            
            Dictionary<int, int> moneyPool = new Dictionary<int, int> { };
            for (int i = 0; i < denominations.Length; i++)
            {
                int value = moneyAdded / denominations[i];
                moneyPool.Add(denominations[i], value);
                moneyAdded -= value * denominations[i];
            }
            return moneyPool;
        }

        public string EndTransaction(Dictionary<int, int> remainingMoney)
        {
            Exchange = "Money back:\n";
            foreach(KeyValuePair<int, int> kvp in remainingMoney)
            {
                if(kvp.Value != 0)
                {
                    Exchange += "Denomination " + kvp.Key + " - " + kvp.Value + " pcs\n";
                }
            }
            return Exchange;
        }
    }
}
