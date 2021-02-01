using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksCoffee
{
    public partial class AddingDrinks : Form
    {
        IBeverage drink;
        IBeverageRepo drinks;
        public AddingDrinks()
        {
            InitializeComponent();
            drinks = new BeverageRepo();
        }
        public int tempID = 1;
        
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            ofdImageSelector.Title = "Choose an image";
            ofdImageSelector.Filter = "png files, jpg files(*.png, *.jpg)|*.png;*.jpg|All Files|*.*";

            if (ofdImageSelector.ShowDialog() == DialogResult.OK)
            {
                string path = ofdImageSelector.FileName;

                pbAddingPicture.Load(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = $"{txtAddingName.Text},{numAddingPrice.Value},{txtAddingDescription.Text},{comboAddingExtras.SelectedItem}";

            saveFileDialog1.Filter = "txt files|*.txt";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.FileName = "MyFile.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, text);
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (rbCoffee.Checked == true)
            {
                AddCoffee();
                //drink = new Coffee(9, txtAddingName.Text, txtAddingDescription.Text, Convert.ToDouble(numAddingPrice.Value), drink.Image, drink.Background, true, true, true);
            }
            else if (rbTea.Checked == true)
            {
                drink = new Tea(drink.ID, drink.Name, drink.Description, drink.Price, drink.Image, drink.Background, true, true, true, true);
            }
            else if (rbSoda.Checked == true)
            {
                drink = new Soda(drink.ID, drink.Name, drink.Description, drink.Price, drink.Image, drink.Background, true, true, true);
            }
            else if (rbSmoothie.Checked == true)
            {
                drink = new Smoothie(drink.ID, drink.Name, drink.Description, drink.Price, drink.Image, drink.Background, true, true, true);
            }
            
        }
        public List<IBeverage> AddCoffee()
        {

            var koffie = new List<IBeverage>
            {
                new Coffee(9, txtAddingName.Text, txtAddingDescription.Text, Convert.ToDouble(numAddingPrice.Value), pbAddingPicture.ImageLocation, pbAddingPicture.ImageLocation, true, true, true)
            };
            return koffie;
            
        }
    }
}
