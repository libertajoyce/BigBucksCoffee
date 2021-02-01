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
        private string path = "C:/Users/emmad/source/repos/BigBucksCoffeeProject/BigBucksCoffee/bin/Debug/orderDetails.txt";

        public FormShoppingCart()
        {
            InitializeComponent();
            priceCalculator = new PriceCalculator();
            myCart = ShoppingCart.GetCart();
            var drinks = myCart.GetDrinksInCart();
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
            string text = "";

            saveFileDialog1.Filter = "txt files|*.txt";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.FileName = "Inventory.txt";
            //StreamWriter writer = new StreamWriter(path);
            //FileStream fileStream = new FileStream(path, FileMode.Create);
            using (FileStream fileStream = File.Create(path))
            {
                foreach (var drink in beverages)
                {
                    text += $"Product name: {drink.Name} Price: €{drink.Price} Date: {DateTime.Now}{Environment.NewLine}";
                    AddText(fileStream, text);
                    text = "";
                }
            }
                
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    foreach (var drink in beverages)
            //    {
            //        text += $"Product name: {drink.Name} Price: €{drink.Price} Date: {DateTime.Now}{Environment.NewLine}";
            //        AddText(fileStream, text);
            //    }
            //    File.WriteAllText(saveFileDialog1.FileName, (text + "Total order: €" +lblTotal.Text+"\n"));
            //}

        }
        private void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            var drinks = myCart.GetDrinksInCart();
            PlaceOrder(path, drinks);
        }
    }
}