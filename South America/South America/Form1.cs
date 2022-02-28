using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //variable to hold country names
                string countryName;

                //declare StreamReader variable
                StreamReader inputFile;

                //open file & create StreamReader obj
                inputFile = File.OpenText("Countries.txt");

                //clear the current data in ListBox
                countriesListBox.Items.Clear();

                //Read contents of Countries.txt
                while (!inputFile.EndOfStream)
                {
                    //get lines of data from the inputFile Countries.txt
                    countryName = inputFile.ReadLine();

                    //add read line to the ListBox
                    countriesListBox.Items.Add(countryName);
                }
                //close file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //print error
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            countriesListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
