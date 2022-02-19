using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //monthly interest rate constant
            const decimal INTEREST_RATE = 0.005m;

            //local variables
            decimal balance; //holds the acct balance
            int months;  //holds the # of months
            int count = 1; //loop counter, starting val = 1

            //starting balance collection
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                //Get the number of months
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    //caculates end balance
                    while (count <= months)
                    {
                        //add current monthly inerest to balance
                        balance = balance + (INTEREST_RATE * balance);

                        //display the month's ending balance
                        detailListBox.Items.Add("The ending balance " +
                            "for month " + count + " is " + 
                            balance.ToString("c"));

                        //add one to the counter
                        count += 1;
                    }

                    //show ending balance
                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    //invalid number of months was entered
                    MessageBox.Show("Invalid value entered for months.");
                }
            }
            else
            {
                //Iinvalid starting balance entered
                MessageBox.Show("Invalid value entered for starting balance.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all data, and reset focus
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            //listbox clear
            detailListBox.Items.Clear();
            //focus reset
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form/program
            this.Close();
        }
    }
}
