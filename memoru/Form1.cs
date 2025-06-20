using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace memoru
{
    public partial class Form1 : Form
    {
        private Random random;
        private List<string> icons;
        Label firstClicked = null;
        Label secondClicked = null;

        public Form1()
        {
            InitializeComponent();

            // Initialize the Random object  
            random = new Random();

            // Initialize the icons list  
            icons = new List<string>()
               {
                   "!", "!", "N", "N", ",", ",", "k", "k",
                   "b", "b", "v", "v", "w", "w", "z", "z"
               };

            AssignIconsToSquares(); // Moved this call into the existing constructor
        }

        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,  
            // and the icon list has 16 icons,  
            // so an icon is pulled at random from the list  
            // and added to each label  
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
                timer1.Start();
            }
           

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }
    }
}
