using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BigBucksCoffee
{
    public partial class FormShoppingCart : Form
    {
        private PriceCalculator priceCalculator;
        private ShoppingCart myCart;
        private string path = $"C:/Users/{Environment.UserName}/Desktop/orderDetails.txt";
        private IEnumerable<IBeverage> drinks;
        public FormShoppingCart()
        {
            InitializeComponent();
            priceCalculator = new PriceCalculator();
            myCart = ShoppingCart.GetCart();
            drinks = myCart.GetDrinksInCart();
            ShowShoppingCartItems(drinks);
            ShowTotalExclBTW(drinks);
            ShowBTW(drinks);
            ShowTotalInclBTW(drinks);
        }

        public void ShowShoppingCartItems(IEnumerable<IBeverage> drinks)
        {
            foreach (var drink in drinks)
            {
                lblTest.Text += $"{drink.Name} €{drink.Price} {Environment.NewLine}";
            }
        }

        public void ShowTotalExclBTW(IEnumerable<IBeverage> beverages)
        {
            lblTotalNoBtw.Text = priceCalculator.CalculateTotalWithoutTax(beverages).ToString();
        }

        public void ShowBTW(IEnumerable<IBeverage> beverages)
        {
            lblTaxAmount.Text = priceCalculator.CalculateTax(beverages).ToString();
        }

        public void ShowTotalInclBTW(IEnumerable<IBeverage> beverages)
        {
            ShoppingCart shoppingCart = ShoppingCart.GetCart();
            lblTotal.Text = shoppingCart.CalculatePrice(beverages).ToString();
        }

        public void PlaceOrder(string path, IEnumerable<IBeverage> beverages)
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                foreach (var drink in beverages)
                {
                    writer.WriteLine($"Product name: {drink.Name} Price: €{drink.Price} Date: {DateTime.UtcNow}");
                }
                writer.Close();
            }

        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            var drinks = myCart.GetDrinksInCart();
            PlaceOrder(path, drinks);
            this.Close();
        }
        
    }
}