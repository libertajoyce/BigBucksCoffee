using BigBucksCoffee;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace BigBucksCoffee.Test
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void GetCart_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var shoppingCart = new ShoppingCart();

            // Act
            var result = shoppingCart.GetCart();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void AddDrinkToCart_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var shoppingCart = new ShoppingCart();
            IBeverage beverage = null;

            // Act
            shoppingCart.AddDrinkToCart(
                beverage);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetDrinksInCart_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var shoppingCart = new ShoppingCart();

            // Act
            var result = shoppingCart.GetDrinksInCart();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculatePrice_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var shoppingCart = new ShoppingCart();
            IEnumerable beverages = null;

            // Act
            var result = shoppingCart.CalculatePrice(
                beverages);

            // Assert
            Assert.Fail();
        }
    }
}
