using System.Collections.Generic;
using System.Linq;

namespace BigBucksCoffee
{
    public class BeverageRepo : IBeverageRepo
    {
        private IList<IBeverage> drinks;

        public BeverageRepo()
        {
            drinks = GetInitialBeverages();
            AddDrinkExample();
        }

        private List<IBeverage> GetInitialBeverages()
        {
            var drinks = new List<IBeverage>
        {
            new Tea(1, "Green Tea","Just green tea", 3, @"Images\greenTea.png",@"BackgroundImages\greenTea.png", true,true,false,true),
            new Tea(2, "Black Tea","Just black tea", 4, @"Images\blackTea.jpg",@"BackgroundImages\blackTea.png", true,false,true,true),
            new Coffee(3, "Black Coffee", "Black coffee", 2.5, @"Images\blackCoffee.jpg",@"BackgroundImages\coffeeBlack.png", false, true, false),
            new Smoothie(4,"Morning smoothie","Strawberry Banana", 6.99,@"Images\strawberrySmoothie.jpg",@"BackgroundImages\strawberrySmoothie.png",true,true,true),
            new Soda(5, "Fanta orange","Fanta orange", 2.5,@"Images\fanta.jpg",@"BackgroundImages\fanta.png",false,true,false),
            new Soda(6, "Coca Cola", "Regular coke.", 2.5, @"Images\cola.jpg",@"BackgroundImages\cola.png", false, true, true)
        };

            return drinks;
        }

        public IList<IBeverage> GetBeverages()
        {
            return drinks;
        }

        public IBeverage GetDrink(int id)
        {
            IList<IBeverage> allDrinks = GetBeverages();
            var listOfBeverages = allDrinks.Where(x => x.ID == id).FirstOrDefault();

            return listOfBeverages;
        }

        public void AddDrink(IBeverage beverage)
        {
            drinks.Add(beverage);
        }
        private void AddDrinkExample()
        {
           var tea =  new Tea(7, "Tea 1", "Just a tea", 3, @"Images\greenTea.png", @"BackgroundImages\greenTea.png", false, true, false, false);
           var coffee = new Coffee(8, "Coffee with milk", "Coffee with milk", 2.5, @"Images\blackCoffee.jpg", @"BackgroundImages\coffeeBlack.png", false, true, false);
           AddDrink(tea);
           AddDrink(coffee);
        }
    }
}