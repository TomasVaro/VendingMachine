using System;
using Xunit;
using VendingMachine.Model;
using System.Collections.Generic;
using VendingMachine.Products;

namespace VendingMachine.Tests
{
    public class TheVendingMachineTests
    {
        [Fact]
        public void WelcomeInfoTest()
        {
            //Arrange
            TheVendingMachine vendingMachine = new TheVendingMachine();
            string expected = "Welcome to Vending Machine\n";
            //Act
            string actual = vendingMachine.WelcomeInfo();
            //Asser
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PurchaseTest()
        {
            //Arrange
            TheVendingMachine vendingMachine = new TheVendingMachine();
            Toy toy = new Toy("Toy", "Rubik's kube", 125, "Might drive you crazy!", true);
            Dictionary<int, int> moneyPool = new Dictionary<int, int>
            {
                [1000] = 2,
                [500] = 0,
                [100] = 2,
                [50] = 0,
                [20] = 1,
                [10] = 1,
                [5] = 0,
                [1] = 1
            };
            Dictionary<int, int> expected = new Dictionary<int, int>
            {
                [1000] = 2,
                [500] = 0,
                [100] = 1,
                [50] = 0,
                [20] = 0,
                [10] = 0,
                [5] = 1,
                [1] = 1
            };
            //Act
            Dictionary<int, int> actual = vendingMachine.Purchase(toy, moneyPool);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowAllTest()
        {
            //Arrange
            TheVendingMachine vendingMachine = new TheVendingMachine();
            Food food = new Food("Food", "Brownies", 14, "Open the plastic bag and eat the brownie.", 3450, 275);
            Drink drink = new Drink("Drink", "Rohanberry", 33, "Drink slowly.", 400);
            Toy toy = new Toy("Toy", "Rubik's kube", 125, "Might drive you crazy!", true);
            vendingMachine.AllProducts.Add(food);
            vendingMachine.AllProducts.Add(drink);
            vendingMachine.AllProducts.Add(toy);
            bool expected = true;
            //Act
            bool actual = vendingMachine.ShowAll();
            //Assert
            Assert.Equal(expected, actual);

            //Arrange
            vendingMachine.AllProducts.Add(null);
            //Act
            ArgumentNullException result = Assert.Throws<ArgumentNullException>(() => vendingMachine.ShowAll());
            //Assert
            Assert.Equal("Value cannot be null. (Parameter 'Could not show list because 'null' is passed in.')", result.Message);
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
                [1] = 1
            };
            //Act
            TheVendingMachine vendingMachine = new TheVendingMachine();
            Dictionary<int, int> actual = vendingMachine.InserMoney(moneyToAdd);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EndTransactionTest()
        {
            //Arrange
            int remaining = 2231;
            TheVendingMachine vendingMachine = new TheVendingMachine();
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