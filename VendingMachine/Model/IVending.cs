using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public interface IVending
    {
        void Purchase();
        void ShowAll();
        void InserMoney();
        void EndTransaction();
    }
}
