using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Object of Dice class with same number of sides
        Dice dice1 = new Dice(5);
        Dice dice2 = new Dice(5);

        // Create int variable that stores the number of rolls
        int numberOfRolls = 0;

        private void btnRollDice_Click(object sender, EventArgs e) // Roll Dice button event handler
        {
            // Call Method rollDie()
            int roll1 = dice1.rollDie();
            int roll2 = dice2.rollDie();

            // Show dice face on the labels
            lblDice1.Text = roll1.ToString();
            lblDice2.Text = roll2.ToString();

            //Increment the value of numberOfRolls by 1 using logical operator(++)
            numberOfRolls++;

            // Create loop that checks for snake eyes
            if (roll1 == 1 && roll2 == 1)
            {
                btnRollDice.Enabled = false;

                // Show MessageBox
                MessageBox.Show("It took " + numberOfRolls + " rolls to get snake eyes!");
            }
        }
    }

    // Create Dice Class
        class Dice // name of class and the beginning of the class. 
        {
        // A private field for the number of sides of the die
        private int numberOfSides;
        
        // Constructor that takes an integer between 4 and 20, inclusive and sets the number of sides of the die
        public Dice(int numbeSides)
        {
            // Checks the number of sides
            if (numbeSides >= 4 && numbeSides <= 20)
            {
                // When numbeSides between 4 to 20 inclusive then. 
                numberOfSides = numbeSides;
            }
            else
            {
                // When invalid sides are entered then
                MessageBox.Show("Number of sides should be between 4 to 20 inclusive");
                
            }
        }// This is the end of the constructor

        // Create Method (rollDie()) that returns the face value when the die is rolled
        public int rollDie()
        {
            // Object of Random class
            Random randomDie = new Random();

            // Random number to roll the die
            return randomDie.Next(numberOfSides);
        }// The end of the method (rollDie())

        }// The end of the class (Dice). 



    
}
