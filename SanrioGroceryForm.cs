// Using built-in libraries for Windows Forms and the tools within the app, including labels, buttons, text boxes, list, images, message boxes, links, etc
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics.Eventing.Reader; 

// Name of my project where all my forms and code is stored
namespace WindowsFormsApp2
{
    // Represents an additional form in my project 
    public partial class SanrioGroceryForm : Form
    {
        // 4.667% Tax rate constant       
        const double Tax_rate = 0.04667;
        // Variable created to store the index of the randomly selected out-of-stock item
        private int outOfStockIndex;
        // Random number generator used for out-of-stock item selection 
        private Random rand = new Random();

        // Plays computer error sound 
        SoundPlayer player = new SoundPlayer("computer-error sound.wav");

        // Plays mouse clikcing sound 
        SoundPlayer player1 = new SoundPlayer("mouse-clicking-sound.wav");

        // Plays alert sound 
        SoundPlayer player2 = new SoundPlayer("alert-sound.wav");

        // Plays computer error sound 
        SoundPlayer player3 = new SoundPlayer("computer-error sound.wav");

        // Plays a cash register sound
        SoundPlayer player4 = new SoundPlayer("cash-register-purchase-sound.wav");

        // Plays a cash register sound
        SoundPlayer player5 = new SoundPlayer("clock-clicking.wav");

        // Runs first when the form is initially created 
        public SanrioGroceryForm()
        {
            // Sets up all the buttons, labels, textboxes, and controls
            InitializeComponent();
        }
        // Runs when the form is created
        private void SanrioGroceryForm_Load(object sender, EventArgs e)
        {
            // Plays clock ticking sound 
            player5.Play();

            // Displays a welcome message and asks the user if they want to shop 
            DialogResult result = MessageBox.Show(
                "Welcome to Hello Kitty's favorite grocery store, Sanrio Mart!\n\n" +
                "Hello Kitty needs your help shopping for items to make her favorite foods.\n\n" +
                "Would you like to start shopping with Hello Kitty now?\n\n",
                "Shopping with Hello Kitty is so much fun",
                // Displays two buttons on the message box, Yes and No
                MessageBoxButtons.YesNo,
                // Displays a question mark icon
                MessageBoxIcon.Question
                );

            // Plays mouse clikcing sound 
            player1.Play();

            // If the user selects No, closes the form and stops running 
            if (result == DialogResult.No)
            {
                // Plays alert sound 
                player2.Play();

                // closes the Sanrio Grocery form 
                this.Close();
                // stops the form from going further
                return;
            }
            // Randomly pikcs one grocery item to be out-of-stock from the list
            outOfStockIndex = rand.Next(0, checkedListBoxGroceries.Items.Count);
        }
        // Prevents the user from selecting out-of-stock item
        private void checkedListBoxGroceries_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Checks if the selected item is out of stock
            if (e.Index == outOfStockIndex)
            {
                // Plays computer error sound 
                player.Play();

                // Displays a message box informing the user that the selected item is unavailable (out of stock)
                MessageBox.Show(
                    $"Sorry! '{checkedListBoxGroceries.Items[e.Index]}' is out of stock. Please select another item.",
                    // Sets the title message of the message box
                    "Out of Stock", 
                    // Displays an OK button in the message box 
                    MessageBoxButtons.OK, 
                    // Displays a warning icon in the message box 
                    MessageBoxIcon.Warning);
                // unchecks the item automatically, prevents the out-of-stock item from being checked 
                e.NewValue = CheckState.Unchecked;
            }
        }

        // Returns an array of strings, where each string represents a grocery item name. Order of item corresponds to order of prices in GetGroceryPrices()
        private string[] GetGroceryItems()
        {
            // Creates and returns a new string array, each grocery item corresponds to a specific price determined by index
            return new string[]
            {
                "Apples", // index 0 
                "Baking Flour", // index 1
                "Strawberries", // index 2
                "Eggs", // index 3
                "Milk", // index 4
                "Pancake Mix", // index 5
                "Whipped Cream", // index 6
                "Chocolate Pudding", // index 7
                "Cookies", // index 8 
                "Kiwi", // index 9
                "Green Tea Matcha", // index 10
                "Sugar", // index 11
                "Butter", // index 12
                "Maple Syrup", // index 13
                "Sushi Bento", // index 14 
                "Apple Pie", // index 15
                "Blueberry Cheesecake", // index 16 
                "Glazed Donut", // index 17
                "Green Tea Ice Cream", // index 18 
                "Lemon Tart", // index 19 
                "Watermelon Lemonade", // index 20
            };
        }
        // Returns an array of double values, each value in the array represents the price of a grocery time which are matched to them by index
        private double[] GetGroceryPrices()
        {
            // Creates and returns a new array of double values, each price corresponds to a specific grocery item determined by index
            return new double[]
            {
                0.89, // Apples
                1.25, // Baking Flour
                3.50, // Strawberries
                1.99, // Eggs
                2.12, // Milk
                1.60, // Pancake Mix 
                0.75, // Whipped Cream
                2.50, // Chocolate Pudding 
                1.77, // Cookies
                0.95, // Kiwi 
                3.25, // Green Tea Matcha
                1.42, // Sugar
                2.62, // Butter
                1.34, // Maple Syrup
                9.98, // Sushi Bento
                2.99, // Apple Pie
                3.99, // Blueberry Cheesecake 
                0.99, // Glazed Donut
                3.25, // Green Tea Ice Cream
                2.60, // Lemon Tart
                3.50, // Watermelon Lemonade 

            };
        }

        private void ResetGroceries()
        {   // Loops through all grocery items in the CheckedListBox, loop starts at first item located at index 0 and continues until the last item 
            for (int i = 0; i < checkedListBoxGroceries.Items.Count; i++)
            {
                // Unchecks the item at the selected index, resetting the user's grocery selections
                checkedListBoxGroceries.SetItemChecked(i, false);
            }

            // Picks a new random out-of-stock item
            outOfStockIndex = rand.Next(0, checkedListBoxGroceries.Items.Count);
        }

        // Runs when Checkout button is clicked
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Ensures user cannot select more than 10 itmes
            while (checkedListBoxGroceries.CheckedItems.Count > 10)
            {
                // Plays computer error sound 
                player3.Play();
                // Displays a message box informing the user that they have selected more than 10 times, prevents checking out
                MessageBox.Show("Sorry, Hello Kitty can only add up to 10 items to her shopping cart per purchase",
                "10 Item limit",
                MessageBoxButtons.OK,
                // Displays a warning icon in the message box 
                MessageBoxIcon.Warning);
                // Ends the checkout and stops the program from calculating totals and displaying reciept 
                return;
            }
            // Gets the grocery items and prices
            string[] items = GetGroceryItems();
            double[] price = GetGroceryPrices();

            // Variable created to store the total cost before tax 
            double subtotal = 0;
            // Builds the text for the reciept line by line 
            StringBuilder receipt = new StringBuilder();
            
            // Adds the title to the receipt
            receipt.AppendLine("Hello Kitty's Grocery Receipt");
            // Adds a separator line on the reciept
            receipt.AppendLine("*****************************");

            // Loops through each index number(checkedIndices) of the checked items the user selected
            foreach (int index in checkedListBoxGroceries.CheckedIndices)
            {
                /* Adds one line to the reciept showing name of the item, which is aligned to the left
                with a padding of 20 characters, and the price using decimals for dollar amount*/
                receipt.AppendLine($"{items[index],-20} ${price[index]:0.00}");
                // Adds the price of the item to the subtotal 
                subtotal += price[index];
            }
            // Calculates the tax and grand total
            double tax = subtotal * Tax_rate; // done by multiplying the subtotal by tax rate
            double total = subtotal + tax; // done by adding the tax to the subtotal

            // Outputs the totals to the user 
            receipt.AppendLine("*****************************"); // Separator
            receipt.AppendLine($"Subtotal: ${subtotal:0.00}"); // Subtotal line
            receipt.AppendLine($"Tax (4%): ${tax:0.00}"); // Tax line
            receipt.AppendLine($"Total: ${total:0.00}"); // Total cost line

            // Plays a cash register sound
            player4.Play();

            // Shows the receipt 
            MessageBox.Show(receipt.ToString());
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Resets the grocery checked itesm when "Shop Again" button is clicked 
        private void btnShopAgain_Click(object sender, EventArgs e)
        {
            // Loops through all grocery items and unchecks them 
            for (int i = 0; i < checkedListBoxGroceries.Items.Count; i++)
                checkedListBoxGroceries.SetItemChecked(i, false);

            // Picks a new random out-of-stock item
            outOfStockIndex = rand.Next(0, checkedListBoxGroceries.Items.Count);

            MessageBox.Show("You may begin shopping again!");

            // Plays mouse clikcing sound 
            player1.Play();
        }

        // Stops shopping and closes the form 
        private void btnStopShopping_Click(object sender, EventArgs e)
        {
            // Creates a a message box asking the user for confirmation before exiting the application 
            DialogResult result = MessageBox.Show(
               "Are you sure you want to stop shopping?",
               "Stop Shopping",
               // Displays two buttons on the message box, Yes and No
               MessageBoxButtons.YesNo,
               // Displays a question mark icon
               MessageBoxIcon.Question
            );

            // Plays mouse clicking sound
            player1.Play();

            // Asks the user to make a decision 
            if (result == DialogResult.Yes)
            {
                // Plays alert sound 
                player2.Play();
                // Closes the form
                this.Close();
            }
            else
            {
                player1.Play();
                // User selects No and groceries checked items are reset to unchecked
                ResetGroceries();

                // Creates a message box telling the user their cart has been cleared and to continue shopping 
                MessageBox.Show(
                    "Your shopping cart has been cleared. You may continue shopping!",
                    "Continue Shopping",
                     MessageBoxButtons.OK
                 );
                // Plays mouse clikcing sound
                player1.Play();
            }

        }
    }
}







