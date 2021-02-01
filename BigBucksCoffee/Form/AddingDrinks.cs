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
        IBeverage drinks;
        IBeverageRepo repo;

        public AddingDrinks()
        {
            InitializeComponent();
            repo = new BeverageRepo(); 
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
            string text = $"{txtAddingName.Text},{numAddingPrice.Value},{txtAddingDescription.Text},{clbAddingExtras.SelectedItem}";

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
            string name = txtAddingName.Text;
            string description = txtAddingDescription.Text;
            double price = Convert.ToDouble(numAddingPrice.Value);
            string image = pbAddingPicture.ImageLocation;
            string backgroundImage = pbAddingPicture.ImageLocation;


            if (rbCoffee.Checked == true)
            {
                drinks = new Coffee(10, name, description, price, image, backgroundImage, true, true, true);
            }
            else if (rbTea.Checked == true)
            {
                drinks = new Tea(drinks.ID, drinks.Name, drinks.Description, drinks.Price, drinks.Image, drinks.Background, true, true, true, true);
            }
            else if (rbSoda.Checked == true)
            {
                drinks = new Soda(drinks.ID, drinks.Name, drinks.Description, drinks.Price, drinks.Image, drinks.Background, true, true, true);
            }
            else if (rbSmoothie.Checked == true)
            {
                drinks = new Smoothie(drinks.ID, drinks.Name, drinks.Description, drinks.Price, drinks.Image, drinks.Background, true, true, true);
            }
            repo.AddDrink(drinks);
        }

        private void rbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            clbAddingExtras.Items.Clear();
            clbAddingExtras.Items.Add("Contains milk");
            clbAddingExtras.Items.Add("Contains sugar");
            clbAddingExtras.Items.Add("Contains alcohol");
            
        }

        private void rbTea_CheckedChanged(object sender, EventArgs e)
        {
            clbAddingExtras.Items.Clear();
            clbAddingExtras.Items.Add("Contains milk");
            clbAddingExtras.Items.Add("Contains sugar");
            clbAddingExtras.Items.Add("Contains honey");
            clbAddingExtras.Items.Add("Contains lemon");
        }

        private void rbSoda_CheckedChanged(object sender, EventArgs e)
        {
            clbAddingExtras.Items.Clear();
            clbAddingExtras.Items.Add("Contains no sugar, is diet");
            clbAddingExtras.Items.Add("Is carbonated");
            clbAddingExtras.Items.Add("Contains caffeine");
        }

        private void rbSmoothie_CheckedChanged(object sender, EventArgs e)
        {
            clbAddingExtras.Items.Clear();
            clbAddingExtras.Items.Add("Contains yoghurt");
            clbAddingExtras.Items.Add("Contains milk");
            clbAddingExtras.Items.Add("Contains no lactose, soy alternative");
        }
    }
}
