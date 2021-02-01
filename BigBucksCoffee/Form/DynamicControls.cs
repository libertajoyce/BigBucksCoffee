using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserControls;

namespace BigBucksCoffee
{
    public partial class DynamicControls : Form
    {
        private IBeverageRepo beverageRepo;
        private IList<IBeverage> drinks;
        private IShoppingCart shoppingCart;

        public DynamicControls()
        {
            InitializeComponent();
            beverageRepo = BeverageRepo.GetBeverageRepo();
            RefreshControls();
            shoppingCart = ShoppingCart.GetCart();
        }

        private void RefreshControls()
        {
            drinks = beverageRepo.GetBeverages();
            GenerateControlsForDrinks(drinks);
        }

        private void GenerateControlsForDrinks(IEnumerable<IBeverage> drinks)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (IBeverage drink in drinks)
            {
                MyUserControl myUserControl = new MyUserControl
                {
                    DrinkId = drink.ID,
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
            IBeverage drink = beverageRepo.GetDrink(myUserControl.DrinkId);

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControls();
        }
    }
}