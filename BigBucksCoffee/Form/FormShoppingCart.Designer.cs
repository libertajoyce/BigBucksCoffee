
namespace BigBucksCoffee
{
    partial class FormShoppingCart
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
            this.lblItems = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTotalNoBtw = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.lblInclBtw = new System.Windows.Forms.Label();
            this.lblExclBtw = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(48, 29);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(41, 17);
            this.lblItems.TabIndex = 8;
            this.lblItems.Text = "Items";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(215, 461);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 17);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "label3";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(215, 414);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(46, 17);
            this.lblTaxAmount.TabIndex = 14;
            this.lblTaxAmount.Text = "label2";
            // 
            // lblTotalNoBtw
            // 
            this.lblTotalNoBtw.AutoSize = true;
            this.lblTotalNoBtw.Location = new System.Drawing.Point(215, 361);
            this.lblTotalNoBtw.Name = "lblTotalNoBtw";
            this.lblTotalNoBtw.Size = new System.Drawing.Size(46, 17);
            this.lblTotalNoBtw.TabIndex = 13;
            this.lblTotalNoBtw.Text = "label1";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(84, 414);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(71, 17);
            this.lblBtw.TabIndex = 11;
            this.lblBtw.Text = "21% BTW";
            // 
            // lblInclBtw
            // 
            this.lblInclBtw.AutoSize = true;
            this.lblInclBtw.Location = new System.Drawing.Point(48, 461);
            this.lblInclBtw.Name = "lblInclBtw";
            this.lblInclBtw.Size = new System.Drawing.Size(104, 17);
            this.lblInclBtw.TabIndex = 10;
            this.lblInclBtw.Text = "Total incl. BTW";
            // 
            // lblExclBtw
            // 
            this.lblExclBtw.AutoSize = true;
            this.lblExclBtw.Location = new System.Drawing.Point(48, 361);
            this.lblExclBtw.Name = "lblExclBtw";
            this.lblExclBtw.Size = new System.Drawing.Size(107, 17);
            this.lblExclBtw.TabIndex = 9;
            this.lblExclBtw.Text = "Total excl. BTW";
            // 
            // lblTest
            // 
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTest.Location = new System.Drawing.Point(52, 59);
            this.lblTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(395, 266);
            this.lblTest.TabIndex = 17;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(342, 476);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(159, 42);
            this.btnPlaceOrder.TabIndex = 18;
            this.btnPlaceOrder.Text = "Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // FormShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 530);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblExclBtw);
            this.Controls.Add(this.lblInclBtw);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalNoBtw);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblBtw);
            this.Name = "FormShoppingCart";
            this.Text = "My Shopping Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblTotalNoBtw;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.Label lblInclBtw;
        private System.Windows.Forms.Label lblExclBtw;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}