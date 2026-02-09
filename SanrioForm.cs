// Using built-in libraries for Windows Forms and the tools within the app, including labels, buttons, text boxes, message boxes, links, etc
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // New addition, plays a sound

// Name of my project where all my forms and code is stored
namespace WindowsFormsApp2
{

    // Represents an additional form in my project
    public partial class NewSanrioGUI : Form
    {
        // Plays welcome sound for background music  
        private SoundPlayer bgMusic = new SoundPlayer("opening-cartoon-sound.wav");

        // Runs first when the form is initially created 
        public NewSanrioGUI()

        {
            // Sets up all the buttons, labels, textboxes, and controls
            InitializeComponent();
        }

        // Runs when the user clicks the "Click Me to Play" button 
        private void Open_NewWin(object sender, EventArgs e)
        {
            // Creates a new window for the main Sanrio window
            SanrioMain sanrioMain = new SanrioMain();
            // Ensures SanrioMain window stays visible 
            this.Visible = true;    
            // Displays the Main window of my GUI project to user
            sanrioMain.Show();

            // Plays sound(background music) on a loop until its stopped 
            bgMusic.PlayLooping();

            // Disables the button so it can only be clicked once
            PushMe_Click1.Enabled = false;

        }
        // This method will run later when the form initially loads
        private void NewSanrioGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
