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
            vendingMachine.CreateProducts();
            Console.WriteLine(vendingMachine.WelcomeInfo());
            Console.WriteLine("How much money do you want to put into the Vending Machine?");
            int moneyLeft;
            while (!int.TryParse(Console.ReadLine(), out moneyLeft) || moneyLeft <= 0)
            {
                Console.WriteLine("You may only enter whole numbers above zero! Try agian.");
            }
            Dictionary<int, int> moneyPool = vendingMachine.InserMoney(moneyLeft);
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You have " + moneyLeft + " kr to buy for.\nDo you want to buy a product (1) or end transaction (2)?");
                string keypress = Console.ReadKey().KeyChar.ToString();
                if (keypress == "1")
                {
                    Console.WriteLine("\n\nThese are the products in the Vending Machine. Choose 1-" + vendingMachine.AllProducts.Count + " to buy:\n");
                    vendingMachine.ShowAll();
                    
                    int nrChoosen;
                    while (!int.TryParse(Console.ReadLine(), out nrChoosen) || nrChoosen <= 0 || nrChoosen > vendingMachine.AllProducts.Count)
                    {
                        Console.WriteLine("You may only enter digits between 1-" + vendingMachine.AllProducts.Count + ". Try agian.");
                    }
                    Product choosenProduct = vendingMachine.AllProducts[nrChoosen - 1];

                    if (choosenProduct.Price > moneyLeft)
                    {
                        Console.WriteLine("You don't have enough money to buy this product! (Hit a key)");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("How many " + choosenProduct.ProductName + " do you want to buy?");
                        int quantity;
                        int costThisbuy = 0;
                        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                        {
                            Console.WriteLine("You may only enter digits above 0. Try agian.");
                        }

                        if (choosenProduct.Price * quantity > moneyLeft)
                        {
                            Console.WriteLine("You don't have enough money to buy " + quantity + " pieces of this product! (Hit a key)");
                            Console.ReadKey();
                        }
                        else
                        {
                            for (int i = 0; i < quantity; i++)
                            {
                                costThisbuy += choosenProduct.Price;
                                if (costThisbuy <= moneyLeft)
                                {
                                    moneyPool = vendingMachine.Purchase(choosenProduct, moneyPool);
                                }
                                else
                                {
                                    Console.WriteLine("You don't have enough money to buy this product!");
                                    Console.ReadKey();
                                }
                            }
                            moneyLeft -= costThisbuy;

                            Console.WriteLine("\nFor a total sum of " + costThisbuy + " kr you bought " +
                                quantity + " pieces of " + choosenProduct.Examine(choosenProduct) +
                                "\nUser information: " + choosenProduct.Use(choosenProduct) +
                                "\n\nYou have " + moneyLeft + " kr left to buy for. (Hit a key)");
                            Console.ReadKey();
                        }
                    }
                }
                else if (keypress == "2")
                {
                    Console.WriteLine("\n\n" + vendingMachine.EndTransaction(moneyPool));
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}