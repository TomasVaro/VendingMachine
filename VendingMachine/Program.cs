using System;
using System.Collections.Generic;
using VendingMachine.Model;
using VendingMachine.Products;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            TheVendingMachine vendingMachine = new TheVendingMachine();
            Console.WriteLine(vendingMachine.welcomeInfo());

            Console.WriteLine("How much money do you want to put into the Vending Machine?");
            int moneyAdded = int.Parse(Console.ReadLine());
            Dictionary<int, int> insertedMoney = vendingMachine.InserMoney(moneyAdded);

            Food food1 = new Food("Brownies", 14, "Open the plastic bag and eat the brownie.");
            Food food2 = new Food("Sandwich", 27, "Split the sandwich in two and eat it.");
            Drinks drink1 = new Drinks("Elderflower", 22, "Open the lid carefully and drink it.");
            Drinks drink2 = new Drinks("Rohanberry", 33, "Drink slowly.");
            Toys toy1 = new Toys("Rubik's kube", 125, "Might drive you crazy!");
            Toys toy2 = new Toys("Lego car", 245, "Be careful not to loose any pieces.");
            vendingMachine.AllProducts.Add(food1);
            vendingMachine.AllProducts.Add(food2);
            vendingMachine.AllProducts.Add(drink1);
            vendingMachine.AllProducts.Add(drink2);
            vendingMachine.AllProducts.Add(toy1);
            vendingMachine.AllProducts.Add(toy2);
            vendingMachine.ShowAll();

            Console.ReadKey();
        }
    }
}
