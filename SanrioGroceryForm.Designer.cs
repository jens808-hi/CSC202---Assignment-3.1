namespace WindowsFormsApp2
{
    partial class SanrioGroceryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanrioGroceryForm));
            this.btnCheckout = new System.Windows.Forms.Button();
            this.checkedListBoxGroceries = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShopAgain = new System.Windows.Forms.Button();
            this.btnStopShopping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCheckout.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.MistyRose;
            this.btnCheckout.Location = new System.Drawing.Point(584, 560);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(218, 70);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout ";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // checkedListBoxGroceries
            // 
            this.checkedListBoxGroceries.AllowDrop = true;
            this.checkedListBoxGroceries.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkedListBoxGroceries.BackColor = System.Drawing.Color.Bisque;
            this.checkedListBoxGroceries.CheckOnClick = true;
            this.checkedListBoxGroceries.ColumnWidth = 230;
            this.checkedListBoxGroceries.Font = new System.Drawing.Font("Liberation Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxGroceries.ForeColor = System.Drawing.Color.RosyBrown;
            this.checkedListBoxGroceries.FormattingEnabled = true;
            this.checkedListBoxGroceries.HorizontalScrollbar = true;
            this.checkedListBoxGroceries.Items.AddRange(new object[] {
            "Apple Pie",
            "Apples",
            "Baking Flour",
            "Blueberry Cheesecake",
            "Butter",
            "Chocolate Pudding",
            "Cookies ",
            "Eggs",
            "Glazed Donuts",
            "Green Tea Ice Cream",
            "Green Tea Matcha",
            "Kiwi",
            "Lemon Tarts",
            "Maple Syrup",
            "Milk",
            "Pancake Mix",
            "Strawberries",
            "Sugar",
            "Sushi Bento",
            "Watermelon Lemonade",
            "Whipped Cream"});
            this.checkedListBoxGroceries.Location = new System.Drawing.Point(54, 210);
            this.checkedListBoxGroceries.MultiColumn = true;
            this.checkedListBoxGroceries.Name = "checkedListBoxGroceries";
            this.checkedListBoxGroceries.ScrollAlwaysVisible = true;
            this.checkedListBoxGroceries.Size = new System.Drawing.Size(491, 356);
            this.checkedListBoxGroceries.TabIndex = 1;
            this.checkedListBoxGroceries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxGroceries_ItemCheck);
            this.checkedListBoxGroceries.Click += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Sanrio Mart!";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(112, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please select your grocery items below and note that you can only select up to 10" +
    " items per purchase. If an item is out of stock, please select another item.";
            // 
            // btnShopAgain
            // 
            this.btnShopAgain.BackColor = System.Drawing.Color.PowderBlue;
            this.btnShopAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopAgain.Location = new System.Drawing.Point(645, 303);
            this.btnShopAgain.Name = "btnShopAgain";
            this.btnShopAgain.Size = new System.Drawing.Size(129, 36);
            this.btnShopAgain.TabIndex = 4;
            this.btnShopAgain.Text = "Shop Again";
            this.btnShopAgain.UseVisualStyleBackColor = false;
            this.btnShopAgain.Click += new System.EventHandler(this.btnShopAgain_Click);
            // 
            // btnStopShopping
            // 
            this.btnStopShopping.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStopShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopShopping.Location = new System.Drawing.Point(650, 382);
            this.btnStopShopping.Name = "btnStopShopping";
            this.btnStopShopping.Size = new System.Drawing.Size(124, 36);
            this.btnStopShopping.TabIndex = 5;
            this.btnStopShopping.Text = "Stop Shopping";
            this.btnStopShopping.UseVisualStyleBackColor = false;
            this.btnStopShopping.Click += new System.EventHandler(this.btnStopShopping_Click);
            // 
            // SanrioGroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 668);
            this.Controls.Add(this.btnStopShopping);
            this.Controls.Add(this.btnShopAgain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxGroceries);
            this.Controls.Add(this.btnCheckout);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SanrioGroceryForm";
            this.Text = "Sanrio Mart";
            this.Load += new System.EventHandler(this.SanrioGroceryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.CheckedListBox checkedListBoxGroceries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShopAgain;
        private System.Windows.Forms.Button btnStopShopping;
    }
}