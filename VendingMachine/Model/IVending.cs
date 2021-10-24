using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
     interface IVending
    {
        string welcomeInfo();
        void Purchase();
        void ShowAll();
        Dictionary<int, int> InserMoney(int moneyAdded);
        string EndTransaction(Dictionary<int, int> remainingMoney);
    }
}