using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public class VendingMachine : IVending
    {
        public static readonly int[] denominations = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };

        public VendingMachine(){ }

        public void Purchase()
        {
            //To buy a product
        }

        public void ShowAll()
        {
            //Show all products
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

        public void EndTransaction()
        {
            //Returns money left in appropriate amount of change
        }
    }
}
