using System.Collections.Generic;
using System.Linq;

namespace BigBucksCoffee
{
    public class BeverageRepo : IBeverageRepo
    {
        private IList<IBeverage> drinks;

        // Singleton pattern -> Only one instance of this object can ever exist -> No accidental overwriting of data
        private static IBeverageRepo _repo;

        // Singleton pattern -> Private constructor disables external creation of instances
        private BeverageRepo()
        {
            drinks = GetInitialBeverages();
        }

        // Singleton pattern -> Static method. No instance needed.
        // Return existing object if it is asked, and create new one when method is called for the first time
        public static IBeverageRepo GetBeverageRepo()
        {
            if (_repo == null)
            {
                _repo = new BeverageRepo();
            }

            return _repo;
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

            // Return first element in alldrinks where Id equals input.
            IBeverage drink = allDrinks.FirstOrDefault(x => x.ID == id);

            return drink;
        }

        public void AddDrink(IBeverage beverage)
        {
            drinks.Add(beverage);
        }
    }
}