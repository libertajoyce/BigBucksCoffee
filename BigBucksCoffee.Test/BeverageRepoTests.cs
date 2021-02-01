using BigBucksCoffee;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BigBucksCoffee.Test
{
    [TestClass]
    public class BeverageRepoTests
    {
        [TestMethod]
        public void GetBeverages_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var beverageRepo = new BeverageRepo();

            // Act
            var result = beverageRepo.GetInitialBeverages();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetDrink_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var beverageRepo = new BeverageRepo();
            int id = 0;

            // Act
            var result = beverageRepo.GetDrink(
                id);

            // Assert
            Assert.Fail();
        }
    }
}
