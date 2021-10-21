using System;
using System.Collections.Generic;
using VendingMachine.Model;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("How much money do you want to put into the Vending Machine?");
            int moneyAdded = int.Parse(Console.ReadLine());

            Model.VendingMachine vendingMachine = new Model.VendingMachine();
            Dictionary<int, int> insertedMoney = vendingMachine.InserMoney(moneyAdded);
        }
    }
}
