using System;
using System.Collections.Generic;
using VendingMachine.Model;

namespace VendingMachine
{
    class Program
    {
        public readonly int[] denomination = new int[0];
        public int[] Denomination { get { return denomination; } }

        public Program(int[] denomination)
        {
            this.denomination = denomination;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] denom = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
            Program program = new Program(denom);
        }
        public void CreateMoneyPool()
        {
            Dictionary<int, int> moneyPool = new Dictionary<int, int>
            {
                [1] = 0,
                [5] = 0,
                [10] = 0,
                [20] = 0,
                [50] = 0,
                [100] = 0,
                [500] = 0,
                [1000] = 0
            };
        }
    }
}
