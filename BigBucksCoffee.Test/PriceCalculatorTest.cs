using NUnit.Framework;
using System.Collections.Generic;

namespace BigBucksCoffee.Test
{
    internal class PriceCalculatorTest
    {
        private PriceCalculator testPrice;

        [SetUp]
        public void Setup()
        {
            testPrice = new PriceCalculator();
        }

        [Test]
        public void CalculateTax_WhenEnteringBeverages_ReturnTax()
        {
            //Arrange
            List<IBeverage> beverages = new List<IBeverage>
            {
                new Tea(1, "Green Tea","Just green tea", 3, @"Images\greenTea.png",@"BackgroundImages\greenTea.png", true,true,false,true),
                new Tea(2, "Black Tea","Just black tea", 4, @"Images\blackTea.jpg",@"BackgroundImages\blackTea.png", true,false,true,true),
                new Coffee(3, "Black Coffee", "Black coffee", 3, @"Images\blackCoffee.jpg",@"BackgroundImages\coffeeBlack.png", false, true, false),
            };
            //Act
            double result = testPrice.CalculateTax(beverages);

            //Assert
            Assert.AreEqual(2.1, result);
        }

        [Test]
        public void DoesNotExist_TDD_AValue()
        {
            int num1 = 1;
            int num2 = 2;

            int result = testPrice.CalculateSomething(num1,num2);
            int expectedResult = num1 + num2;

            Assert.AreEqual(expectedResult, result);
        }
    }
}