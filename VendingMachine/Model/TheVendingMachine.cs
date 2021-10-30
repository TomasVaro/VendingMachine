using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Products;

namespace VendingMachine.Model
{
    public class TheVendingMachine : IVending
    {
        public static readonly int[] denominations = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        public static List<Product> allProducts = new List<Product>();
        public List<Product> AllProducts { get { return allProducts; } }
        public void CreateProducts()
        {
            TheVendingMachine vendingMachine = new TheVendingMachine();
            Food food1 = new Food("Food", "Brownies", 14, "Open the plastic bag and eat the brownie.", 3450, 275);
            Food food2 = new Food("Food", "Sandwich", 27, "Split the sandwich in two and eat it.", 2445, 155);
            Drink drink1 = new Drink("Drink", "Elderflower", 22, "Open the lid carefully and drink it.", 330);
            Drink drink2 = new Drink("Drink", "Rohanberry", 33, "Drink slowly.", 400);
            Toy toy1 = new Toy("Toy", "Rubik's cube", 125, "Turn and turn and it might drive you crazy!", true);
            Toy toy2 = new Toy("Toy", "Rattle", 245, "Contains small pieces. Use with care!", false);
            vendingMachine.AllProducts.Add(food1);
            vendingMachine.AllProducts.Add(food2);
            vendingMachine.AllProducts.Add(drink1);
            vendingMachine.AllProducts.Add(drink2);
            vendingMachine.AllProducts.Add(toy1);
            vendingMachine.AllProducts.Add(toy2);
        }
        public string WelcomeInfo()
        {
            return "Welcome to Vending Machine\n";
        }

        //Buy a product
        public Dictionary<int, int> Purchase(Product product, Dictionary<int, int> moneyPool)
        {
            int moneyLeft = 0;
            foreach (KeyValuePair<int, int> pair in moneyPool)
            {
                moneyLeft += pair.Key * pair.Value;
            }
            if (moneyLeft >= product.Price) 
            {
                moneyLeft -= product.Price;
                moneyPool = InserMoney(moneyLeft);
            }
            return moneyPool;
        }

        //Show all products except Description
        public bool ShowAll()
        {
            bool succeded;
            try
            {
                TheVendingMachine vendingMachine = new TheVendingMachine();
                if (vendingMachine.AllProducts.Count == 0)
                {
                    Console.WriteLine("Sorry! There are no products in the Vending Machine.");
                }
                int counter = 0;
                foreach (Product products in vendingMachine.AllProducts)
                {
                    counter++;
                    if (products.ProductType == "Food")
                    {
                        Console.WriteLine(counter + " "
                            + products.ProductName + "\t" 
                            + products.Price + " kr\t"  
                            + products.Calories + " kcal\t"
                            + products.Weight + " gr"
                            );
                    }
                    else if (products.ProductType == "Drink")
                    {
                        Console.WriteLine(counter + " "
                            + products.ProductName + "\t"
                            + products.Price + " kr\t"
                            + products.Mililiter + " mL"
                            );
                    }
                    else if (products.ProductType == "Toy")
                    {
                        Console.Write(counter + " "
                            + products.ProductName + "\t"
                            + products.Price + " kr\t"
                            );
                        if (products.ContainsPlastic)
                        {
                            Console.WriteLine("Contains plastic");
                        }
                        else
                        {
                            Console.WriteLine("Doesn't contain plastic");
                        }
                    }
                }
                succeded = true;
            }
            catch
            {
                throw new ArgumentNullException("Could not show list because 'null' is passed in.");
            }
            return succeded;
        }

        //Insert money to the money pool
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

        //End transaction and return the change as a string
        public string EndTransaction(Dictionary<int, int> remainingMoney)
        {
            string exchange = "Money back:\n";
            foreach(KeyValuePair<int, int> kvp in remainingMoney)
            {
                if(kvp.Value != 0)
                {
                    exchange += "Denomination " + kvp.Key + " - " + kvp.Value + " pcs\n";
                }
            }
            return exchange;
        }
    }
}
