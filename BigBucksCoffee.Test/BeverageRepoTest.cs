using System;
using System.Collections.Generic;
using System.Text;
using BigBucksCoffee;
using NUnit.Framework;

namespace BigBucksCoffee.Test
{
    class BeverageRepoTest
    {
        BeverageRepo _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new BeverageRepo();
        }

        [Test]
        public void GetDrink_WhenCalled_ReturnValidObject()
        {
            //Assign
     

            //Act
            IBeverage result = _repo.GetDrink(9);

            //Assert
            Assert.IsNull(result);

        }
    }
}
