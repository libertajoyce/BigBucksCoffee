using BigBucksCoffee;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BigBucksCoffee.Test
{
    [TestClass]
    public class PriceCalculatorTests
    {
        [TestMethod]
        public void CalculateTax_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var priceCalculator = new PriceCalculator();
            IEnumerable beverages = null;

            // Act
            var result = priceCalculator.CalculateTax(
                beverages);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateTotalWithoutTax_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var priceCalculator = new PriceCalculator();
            IEnumerable beverages = null;

            // Act
            var result = priceCalculator.CalculateTotalWithoutTax(
                beverages);

            // Assert
            Assert.Fail();
        }
    }
}
