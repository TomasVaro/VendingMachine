using System;
using Xunit;
using VendingMachine.Model;
using System.Collections.Generic;

namespace VendingMachine.Tests
{
    public class VendingMachineTests
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
            int[] denominations = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
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
            Model.VendingMachine vendingMachine = new Model.VendingMachine(denominations);
            Dictionary<int, int> actual = vendingMachine.InserMoney(moneyToAdd);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EndTransactionTest()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
