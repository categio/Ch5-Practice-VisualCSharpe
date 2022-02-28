using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables to hold val for sales amt and the total sales
                decimal sales, total = 0m;

                //declare StreamReader variable
                StreamReader inputFile;

                //Open & create inputFile object
                inputFile = File.OpenText("Sales.txt");

                //read contents of Sales.txt
                while (!inputFile.EndOfStream)
                {
                    //get sales amount
                    sales = decimal.Parse(inputFile.ReadLine());

                    //add to the total
                    total += sales;
                }

                //close StreamReader file
                inputFile.Close();

                //Display total
                totalLabel.Text = total.ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
