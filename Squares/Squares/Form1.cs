﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //Display the countdown to showing squares
            for (int count = 10; count >= 1; count--)
            {
                outputListBox.Items.Add(count.ToString() + "...");
            }

            //display blast off
            outputListBox.Items.Add("Blast Off!!");

            // Constant for the maximum number
            const int MAX_VALUE = 10;

            // Loop counter
            int number;

            // Display the list of numbers and their squares.
            for (number = 1; number <= MAX_VALUE; number++)
            {
                outputListBox.Items.Add(number + " is " + 
                    (number * number) + " when squared.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all data  from list box
            outputListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form/program
            this.Close();
        }
    }
}
