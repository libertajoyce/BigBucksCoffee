
namespace BigBucksCoffee
{
    partial class AddingDrinks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbCoffee = new System.Windows.Forms.RadioButton();
            this.rbTea = new System.Windows.Forms.RadioButton();
            this.rbSoda = new System.Windows.Forms.RadioButton();
            this.rbSmoothie = new System.Windows.Forms.RadioButton();
            this.gbDrinkChoices = new System.Windows.Forms.GroupBox();
            this.lblAddingName = new System.Windows.Forms.Label();
            this.lblAddingPrice = new System.Windows.Forms.Label();
            this.lblAddingDescription = new System.Windows.Forms.Label();
            this.lblAddingPicture = new System.Windows.Forms.Label();
            this.lblAddingSupplements = new System.Windows.Forms.Label();
            this.txtAddingName = new System.Windows.Forms.TextBox();
            this.txtAddingDescription = new System.Windows.Forms.TextBox();
            this.numAddingPrice = new System.Windows.Forms.NumericUpDown();
            this.comboAddingExtras = new System.Windows.Forms.ComboBox();
            this.pbAddingPicture = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.ofdImageSelector = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbDrinkChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCoffee
            // 
            this.rbCoffee.AutoSize = true;
            this.rbCoffee.Location = new System.Drawing.Point(6, 31);
            this.rbCoffee.Name = "rbCoffee";
            this.rbCoffee.Size = new System.Drawing.Size(79, 24);
            this.rbCoffee.TabIndex = 0;
            this.rbCoffee.TabStop = true;
            this.rbCoffee.Text = "Coffee";
            this.rbCoffee.UseVisualStyleBackColor = true;
            // 
            // rbTea
            // 
            this.rbTea.AutoSize = true;
            this.rbTea.Location = new System.Drawing.Point(6, 58);
            this.rbTea.Name = "rbTea";
            this.rbTea.Size = new System.Drawing.Size(58, 24);
            this.rbTea.TabIndex = 1;
            this.rbTea.TabStop = true;
            this.rbTea.Text = "Tea";
            this.rbTea.UseVisualStyleBackColor = true;
            // 
            // rbSoda
            // 
            this.rbSoda.AutoSize = true;
            this.rbSoda.Location = new System.Drawing.Point(6, 85);
            this.rbSoda.Name = "rbSoda";
            this.rbSoda.Size = new System.Drawing.Size(68, 24);
            this.rbSoda.TabIndex = 2;
            this.rbSoda.TabStop = true;
            this.rbSoda.Text = "Soda";
            this.rbSoda.UseVisualStyleBackColor = true;
            // 
            // rbSmoothie
            // 
            this.rbSmoothie.AutoSize = true;
            this.rbSmoothie.Location = new System.Drawing.Point(6, 112);
            this.rbSmoothie.Name = "rbSmoothie";
            this.rbSmoothie.Size = new System.Drawing.Size(100, 24);
            this.rbSmoothie.TabIndex = 3;
            this.rbSmoothie.TabStop = true;
            this.rbSmoothie.Text = "Smoothie";
            this.rbSmoothie.UseVisualStyleBackColor = true;
            // 
            // gbDrinkChoices
            // 
            this.gbDrinkChoices.Controls.Add(this.btnConfirm);
            this.gbDrinkChoices.Controls.Add(this.rbCoffee);
            this.gbDrinkChoices.Controls.Add(this.rbSmoothie);
            this.gbDrinkChoices.Controls.Add(this.rbTea);
            this.gbDrinkChoices.Controls.Add(this.rbSoda);
            this.gbDrinkChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrinkChoices.Location = new System.Drawing.Point(12, 12);
            this.gbDrinkChoices.Name = "gbDrinkChoices";
            this.gbDrinkChoices.Size = new System.Drawing.Size(362, 152);
            this.gbDrinkChoices.TabIndex = 4;
            this.gbDrinkChoices.TabStop = false;
            this.gbDrinkChoices.Text = "Drinks";
            // 
            // lblAddingName
            // 
            this.lblAddingName.AutoSize = true;
            this.lblAddingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingName.Location = new System.Drawing.Point(8, 181);
            this.lblAddingName.Name = "lblAddingName";
            this.lblAddingName.Size = new System.Drawing.Size(189, 20);
            this.lblAddingName.TabIndex = 5;
            this.lblAddingName.Text = "Enter the product name:";
            // 
            // lblAddingPrice
            // 
            this.lblAddingPrice.AutoSize = true;
            this.lblAddingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingPrice.Location = new System.Drawing.Point(8, 234);
            this.lblAddingPrice.Name = "lblAddingPrice";
            this.lblAddingPrice.Size = new System.Drawing.Size(124, 20);
            this.lblAddingPrice.TabIndex = 6;
            this.lblAddingPrice.Text = "Enter the price:";
            // 
            // lblAddingDescription
            // 
            this.lblAddingDescription.AutoSize = true;
            this.lblAddingDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingDescription.Location = new System.Drawing.Point(8, 349);
            this.lblAddingDescription.Name = "lblAddingDescription";
            this.lblAddingDescription.Size = new System.Drawing.Size(169, 20);
            this.lblAddingDescription.TabIndex = 7;
            this.lblAddingDescription.Text = "Enter the description:";
            // 
            // lblAddingPicture
            // 
            this.lblAddingPicture.AutoSize = true;
            this.lblAddingPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingPicture.Location = new System.Drawing.Point(310, 181);
            this.lblAddingPicture.Name = "lblAddingPicture";
            this.lblAddingPicture.Size = new System.Drawing.Size(202, 20);
            this.lblAddingPicture.TabIndex = 8;
            this.lblAddingPicture.Text = "Choose a product picture:";
            // 
            // lblAddingSupplements
            // 
            this.lblAddingSupplements.AutoSize = true;
            this.lblAddingSupplements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingSupplements.Location = new System.Drawing.Point(8, 287);
            this.lblAddingSupplements.Name = "lblAddingSupplements";
            this.lblAddingSupplements.Size = new System.Drawing.Size(200, 20);
            this.lblAddingSupplements.TabIndex = 9;
            this.lblAddingSupplements.Text = "Choose the extra options:";
            // 
            // txtAddingName
            // 
            this.txtAddingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddingName.Location = new System.Drawing.Point(12, 200);
            this.txtAddingName.Name = "txtAddingName";
            this.txtAddingName.Size = new System.Drawing.Size(231, 34);
            this.txtAddingName.TabIndex = 10;
            // 
            // txtAddingDescription
            // 
            this.txtAddingDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddingDescription.Location = new System.Drawing.Point(12, 372);
            this.txtAddingDescription.Multiline = true;
            this.txtAddingDescription.Name = "txtAddingDescription";
            this.txtAddingDescription.Size = new System.Drawing.Size(231, 148);
            this.txtAddingDescription.TabIndex = 11;
            // 
            // numAddingPrice
            // 
            this.numAddingPrice.DecimalPlaces = 2;
            this.numAddingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddingPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAddingPrice.Location = new System.Drawing.Point(12, 257);
            this.numAddingPrice.Name = "numAddingPrice";
            this.numAddingPrice.Size = new System.Drawing.Size(231, 27);
            this.numAddingPrice.TabIndex = 12;
            // 
            // comboAddingExtras
            // 
            this.comboAddingExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAddingExtras.FormattingEnabled = true;
            this.comboAddingExtras.Location = new System.Drawing.Point(12, 310);
            this.comboAddingExtras.Name = "comboAddingExtras";
            this.comboAddingExtras.Size = new System.Drawing.Size(231, 28);
            this.comboAddingExtras.TabIndex = 14;
            // 
            // pbAddingPicture
            // 
            this.pbAddingPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAddingPicture.Location = new System.Drawing.Point(314, 234);
            this.pbAddingPicture.Name = "pbAddingPicture";
            this.pbAddingPicture.Size = new System.Drawing.Size(194, 181);
            this.pbAddingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddingPicture.TabIndex = 15;
            this.pbAddingPicture.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(314, 433);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(194, 23);
            this.btnSelectImage.TabIndex = 16;
            this.btnSelectImage.Text = "Select image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // ofdImageSelector
            // 
            this.ofdImageSelector.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(239, 85);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(103, 51);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // AddingDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pbAddingPicture);
            this.Controls.Add(this.comboAddingExtras);
            this.Controls.Add(this.numAddingPrice);
            this.Controls.Add(this.txtAddingDescription);
            this.Controls.Add(this.txtAddingName);
            this.Controls.Add(this.lblAddingSupplements);
            this.Controls.Add(this.lblAddingPicture);
            this.Controls.Add(this.lblAddingDescription);
            this.Controls.Add(this.lblAddingPrice);
            this.Controls.Add(this.lblAddingName);
            this.Controls.Add(this.gbDrinkChoices);
            this.Name = "AddingDrinks";
            this.Text = "AddingDrinks";
            this.gbDrinkChoices.ResumeLayout(false);
            this.gbDrinkChoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCoffee;
        private System.Windows.Forms.RadioButton rbTea;
        private System.Windows.Forms.RadioButton rbSoda;
        private System.Windows.Forms.RadioButton rbSmoothie;
        private System.Windows.Forms.GroupBox gbDrinkChoices;
        private System.Windows.Forms.Label lblAddingName;
        private System.Windows.Forms.Label lblAddingPrice;
        private System.Windows.Forms.Label lblAddingDescription;
        private System.Windows.Forms.Label lblAddingPicture;
        private System.Windows.Forms.Label lblAddingSupplements;
        private System.Windows.Forms.TextBox txtAddingName;
        private System.Windows.Forms.TextBox txtAddingDescription;
        private System.Windows.Forms.NumericUpDown numAddingPrice;
        private System.Windows.Forms.ComboBox comboAddingExtras;
        private System.Windows.Forms.PictureBox pbAddingPicture;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.OpenFileDialog ofdImageSelector;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirm;
    }
}