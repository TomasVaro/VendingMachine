using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public interface IVending
    {
        void Purchase();
        void ShowAll();
        Dictionary<int, int> InserMoney(int moneyAdded);
        void EndTransaction();
    }
}
