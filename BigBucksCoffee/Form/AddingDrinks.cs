using NUnit.Framework;
using System;
using System.IO;
using System.Windows.Forms;

namespace BigBucksCoffee
{
    public partial class AddingDrinks : Form
    {
        private IBeverage _drink;
        private IBeverageRepo _repo;

        public AddingDrinks()
        {
            InitializeComponent();
            _repo = BeverageRepo.GetBeverageRepo();
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
            string text = $"{txtAddingName.Text},{numAddingPrice.Value},{txtAddingDescription.Text},{clbAddingExtras.CheckedItems}";

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
            bool hasMilk = CheckItem("Contains milk");
            bool hasSugar = CheckItem("Contains sugar");
            bool hasAlcohol = CheckItem("Contains alcohol");
            bool hasHoney = CheckItem("Contains honey");
            bool hasLemon = CheckItem("Contains lemon");
            bool isDiet = CheckItem("Contains no sugar, is diet");
            bool hasBubbles = CheckItem("Is carbonated");
            bool hasCaffeine = CheckItem("Contains caffeine");
            bool hasYoghurt= CheckItem("Contains yoghurt");
            bool hasLactose = CheckItem("Contains no lactose, soy alternative");

            if (rbCoffee.Checked)
            {
                _drink = new Coffee(10, name, description, price, image, backgroundImage, true, true, true);
            }
            else if (rbTea.Checked)
            {
                _drink = new Tea(10, name, description, price, image, backgroundImage, true, true, true, true);
            }
            else if (rbSoda.Checked)
            {
                _drink = new Soda(10, name, description, price, image, backgroundImage, true, true, true);
            }
            else if (rbSmoothie.Checked)
            {
                _drink = new Smoothie(10, name, description, price, image, backgroundImage, true, true, true);
            }

            _repo.AddDrink(_drink);
        }
        
        private bool CheckItem(string input)
        {
            if (clbAddingExtras.CheckedItems.Equals(input))
            {
                return true;
            }
            return false;
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