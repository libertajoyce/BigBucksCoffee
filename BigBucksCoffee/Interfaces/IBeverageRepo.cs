using System.Collections.Generic;

namespace BigBucksCoffee
{
    public interface IBeverageRepo
    {
        void AddDrink(IBeverage beverage);
        IList<IBeverage> GetBeverages();
        IBeverage GetDrink(int id);
    }
}