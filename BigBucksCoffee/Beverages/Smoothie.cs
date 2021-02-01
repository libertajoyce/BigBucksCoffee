namespace BigBucksCoffee
{
    public class Smoothie : Beverage
    {
        public bool HasYoghurt { get; set; }
        public bool HasMilk { get; set; }
        public bool IsLactoseFree { get; set; }
        public override double Price { get; set; }


        public Smoothie(int id, string name, string description, double price, string image, string background, bool hasYoghurt, bool hasMilk, bool isLactoseFree)
       : base(id, name, description, price, image, background)
        {
            Price = price;
            HasYoghurt = hasYoghurt;
            HasMilk = hasMilk;
            IsLactoseFree = isLactoseFree;

        }

        public override string ToString()
        {
            string yoghurt = HasYoghurt ? "\nWith yoghurt" : "";
            string milk = HasMilk ? "\nContains milk." : "";
            string lactose = IsLactoseFree ? "\nWithout lactose." : "";
            return base.ToString() + $"{yoghurt}{milk}{lactose}";
        }
    }
}