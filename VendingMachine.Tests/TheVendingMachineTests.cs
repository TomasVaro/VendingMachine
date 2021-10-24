using System;
using Xunit;
using VendingMachine.Model;
using System.Collections.Generic;

namespace VendingMachine.Tests
{
    public class TheVendingMachineTests
    {
        [Fact]
        public void PurchaseTest()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void ShowAllTest()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void InserMoneyTest()
        {
            //Arrange
            int moneyToAdd = 2231;
            Dictionary<int, int> expected = new Dictionary<int, int>
            {
                [1000] = 2,
                [500] = 0,
                [100] = 2,
                [50] = 0,
                [20] = 1,
                [10] = 1,
                [5] = 0,
                [1] = 1,
            };
            //Act
            Model.TheVendingMachine vendingMachine = new Model.TheVendingMachine();
            Dictionary<int, int> actual = vendingMachine.InserMoney(moneyToAdd);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EndTransactionTest()
        {
            //Arrange
            int remaining = 2231;
            Model.TheVendingMachine vendingMachine = new Model.TheVendingMachine();
            Dictionary<int, int> remainingMoney = vendingMachine.InserMoney(remaining);
            string expected = "Money back:\nDenomination 1000 - 2 pcs\n" +
                "Denomination 100 - 2 pcs\n" +
                "Denomination 20 - 1 pcs\n" +
                "Denomination 10 - 1 pcs\n" +
                "Denomination 1 - 1 pcs\n";
            //Act
            string actual = vendingMachine.EndTransaction(remainingMoney);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
