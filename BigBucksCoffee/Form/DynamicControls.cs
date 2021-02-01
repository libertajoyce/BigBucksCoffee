using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls;

namespace BigBucksCoffee
{
    public partial class DynamicControls : Form
    {
        BeverageRepo beverageRepo;
        IList<IBeverage> drinks;
        IShoppingCart shoppingCart;

        public DynamicControls()
        {
            InitializeComponent();
            beverageRepo = new BeverageRepo();
            drinks = beverageRepo.GetBeverages();
            GenerateControlsForDrinks(drinks);
            shoppingCart = ShoppingCart.GetCart();
        }

        private void GenerateControlsForDrinks(IEnumerable<IBeverage> drinks)
        {
            foreach (IBeverage drink in drinks)
            {
                MyUserControl myUserControl = new MyUserControl
                {
                    DrinkID = drink.ID,
                    MyProductName = drink.Name,
                    Price = drink.Price.ToString(),
                    //IsInStock = drink.IsInStock,
                    Description = drink.Description,
                    Image = drink.Image,
                    Background = drink.Background
                };

                myUserControl.ButtonAddToCartClicked += OnButtonAddToCartClicked;

                flowLayoutPanel1.Controls.Add(myUserControl);
            }
        }

        private void OnButtonAddToCartClicked(object sender, EventArgs e)
        {
            MyUserControl myUserControl = sender as MyUserControl;
            IBeverage drink = beverageRepo.GetDrink(myUserControl.DrinkID);
                for (int i = 0; i < myUserControl.Amount; i++)
                {
                    shoppingCart.AddDrinkToCart(drink);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formCart = new FormShoppingCart();
            formCart.Show();
            
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            Form addDrinks = new AddingDrinks();
            addDrinks.Show();
        }
    }
}
