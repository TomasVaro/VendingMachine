using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    interface IVending
    {
        string WelcomeInfo();
        Dictionary<int, int> Purchase(Product product, Dictionary<int, int> moneyPool);
        bool ShowAll();
        Dictionary<int, int> InserMoney(int moneyAdded);
        string EndTransaction(Dictionary<int, int> remainingMoney);
    }
}