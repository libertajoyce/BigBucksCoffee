namespace BigBucksCoffee
{
    public abstract class Beverage : IBeverage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private double _price;

        public virtual double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Image { get; set; }
        public string Background { get; set; }

        public Beverage(int id, string name, string description, double price, string image = "Images/coffee2.jpg", string background = "Images/coffee2.jpg")
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            Background = background;
        }

        public override string ToString()
        {
            return $"Name:{Name} \nPrice:{Price} \nDescription:{Description}";
        }
    }
}