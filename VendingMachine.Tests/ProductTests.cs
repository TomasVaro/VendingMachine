using System;
using Xunit;
using VendingMachine.Model;
using System.Collections.Generic;
using VendingMachine.Products;

namespace VendingMachine.Tests
{
    public class ProductTests
    {

        [Fact]
        public void ExamineTest()
        {
            //Arrange
            Food food = new Food("Food", "Brownie", 14, "Open the plastic bag and eat the brownie.", 3450, 275);
            string expected = "Brownie - Food, 275 g, 3450 kcal, 14 kr each.";
            //Act
            string actual = food.Examine(food);
            //Assert
            Assert.Equal(expected, actual);

            //Arrange
            Drink drink = new Drink("Drink", "Elderflower", 22, "Open the lid carefully and drink it.", 330);
            expected = "Elderflower - Drink, 330 ml, 22 kr each.";
            //Act
            actual = drink.Examine(drink);
            //Assert
            Assert.Equal(expected, actual);

            //Arrange
            Toy toy = new Toy("Toy", "Rubik's cube", 125, "Might drive you crazy!", true);
            expected = "Rubik's cube - Toy, Contains plastic, 125 kr each.";
            //Act
            actual = toy.Examine(toy);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UseTest()
        {
            //Arrange
            Drink drink = new Drink("Drink", "Rohanberry", 33, "Drink slowly.", 400);
            string expected = "Drink slowly.";
            //Act
            string actual = drink.Use(drink);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
