// Using built-in libraries for Windows Forms and the tools within the app, including labels, buttons, text boxes, lists, images, message boxes, links, etc
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name of my project where all my forms and code is stored
namespace WindowsFormsApp2
{
    // Represents the GUI's Main/starting window of my project
    public partial class SanrioMain : Form
    {
        // Variable used to a store number recieved by user input
        int number1;
        // Variabe used to track correct answers for score card
        int correctCount = 0;
        // Variable used to track wrong answers for score card
        int wrongCount = 0;
        // Background music for looping sound
        private SoundPlayer bgMusic = new SoundPlayer("opening-cartooon-sound.wav");

        // Runs first when the form is initially created 
        public SanrioMain()
        {
            // Sets up all the buttons, labels, textboxes, and controls
            InitializeComponent();
        }

        private void IncrementCorrect(string message)
        {
            correctCount++;
            MessageBox.Show(message);
        }

        private void IncrementWrong(string message) 
            { 
            wrongCount++; 
            MessageBox.Show(message);
        }
        
        // Runs when the correct button is clicked 
        private void PushMe_Click(object sender, EventArgs e)
        {
            // Output to user that they are correct 
            IncrementCorrect("You are Correct!");
        }

        // Runs when the wrong answer button is clicked
        private void PushMe_Clck2(object sender, EventArgs e)
        {
            // Output to user that they are wrong 
            IncrementWrong("Wrong Answer!");
        }

        // Runs when the wrong answer button is clicked
        private void PushMe_Clck3(object sender, EventArgs e)
        {
            // Output to user that they are wrong 
            IncrementWrong("Wrong Answer!");
        }

        // Runs when the user checks the Year to question 2
        private void CheckInt_Click(object sender, EventArgs e)
        {
            // Converts the text recieved by user input into a number
            if (int.TryParse(NumBox.Text, out number1))
            {
                // If the number is equal to 1974, then the answer is correct 
                if (number1 == 1974)
                {
                    // Output to user that they are correct 
                    IncrementCorrect("Yes, that's correct! The year is " + NumBox.Text + "!");
                }
                else
                {
                    // Output to user that they are wrong
                    IncrementWrong("Nope, that is the WRONG year, Try Again!");
                    // Clears the textbox so user can try again
                    NumBox.Clear();
                }
            } // end outer if
            else
            {
                IncrementWrong("Not a valid integer");
                // Clears the textbox so user can try again
                NumBox.Clear();
            }   // end else
        }

        // Runs when the wrong checkbox 3 is clicked
        private void Check3(object sender, EventArgs e)
        {
            // Output to user that they are wrong
            IncrementWrong("Nope, wrong answer, Try Again!");
            //Clears the checkbox
            chckBox3.Checked = false;
        }

        // Runs when the wrong checkbox 1 is clicked
        private void Check1(object sender, EventArgs e)
        {
            // Output to user that they are wrong
            IncrementWrong("Nope, wrong answer, Try Again!");
            // Clears the checkbox
            chckBox1.Checked = false; 
        }

        // Runs when the correct checkbox 2 is clicked for question 3
        private void Check2(object sender, EventArgs e)
        {
            // Output to user that they are correct 
            IncrementCorrect("Yes, that's Correct");
            // Leaves checkbox checked
            chckBox2.Checked = true; 
        }

        // Runs when user checks the weight to question 4
        private void CheckInt_Click2(object sender, EventArgs e)
        {
            // Retrieves the number selected by user in the up/down numeric control 
            int selectedWeight = (int)NumUpDown1.Value;
            // If the weight is 3, then the answer is correct
            if (selectedWeight == 3)
            {
                // Output to user that they are correct
                IncrementCorrect("Yes, that is the correct weight!");
            }
            else
            {
                // Output to user that they are wrong
                IncrementWrong("That is the wrong weight!, Try Again!");
            }
        }

        // Runs when checking the combo box selection to question 5
        private void CheckInt_Click3(object sender, EventArgs e)
        {
             // Retrieves the name selected by user and removes extra spaces
            String selectedName = nameBox.Text.Trim();
            // Checks if the selected name is "Dear Daniel"
            if (string.Equals(selectedName, "Dear Daniel", StringComparison.OrdinalIgnoreCase))
            {
                // Output to user that they are correct
                IncrementCorrect("Yes, Dear Daniel is Hello Kitty's boyfriend!");
            }
            else
            {
                // Output to user that they are wrong
                IncrementWrong("No, that is NOT Hello Kitty's boyfriend, Try Again!");
            }
        }

        // Runs when the link is clicked
        private void lblHk_Bf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            // Opens Internet Explorer and goes to the video link 
            System.Diagnostics.Process.Start("IExplore", "https://www.bing.com/videos/riverview/relatedvideo?q=dear%20daniel%20hello%20kitty&mid=429998C9548B77833FBF429998C9548B77833FBF&ajaxhist=0");
        }

        // Builds the form and runs when the window intially opens it before any user input
        private void SanrioMain_Load(object sender, EventArgs e)
        {
            // Plays sound in a loop until it's stopped
      
        }

        // Runs when the "Check to View Score" button is clicked
        private void btnCheckScore_Click(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            // Creates a new pop up window to generate the totals of correct and wrong answers 
            scoreCard scoreCard = new scoreCard(correctCount, wrongCount);
            // Shows the score card window to user
            scoreCard.ShowDialog();
        }

        // Creates a new pop up window to generate another game (Sanrio Mart), when "Go Shopping with Hello Kitty" button is clicked
        private void btnSanrioMart_Click(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            SanrioGroceryForm sanrioGrocery = new SanrioGroceryForm();
            // Shows the Sanrio Grocery form 
            sanrioGrocery.Show();

            // Closes the Sanrio Main form
            this.Close();
        }
    }
   
}
