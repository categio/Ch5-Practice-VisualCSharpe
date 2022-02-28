using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare StreamWriter variable
                StreamWriter outputFile;

                //create a file and create outputFile object
                outputFile = File.AppendText("Friend.txt");

                //write name to the file
                outputFile.WriteLine(nameTextBox.Text);

                //close the file
                outputFile.Close();

                //message to let user know data added to file
                MessageBox.Show("The name was written to the file.");
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variable to hold item to read from the file
                string friendName;

                //declare a StreamReader variable
                StreamReader inputFile;

                //Open the file and get an inputFile obj
                inputFile = File.OpenText("Friend.txt");

                //iterate over the document and print each name
                while (!inputFile.EndOfStream)
                {
                    //print to the message box the names
                    friendName = inputFile.ReadLine();
                    MessageBox.Show("You have entered: " +friendName+ ". Click OK "+
                        "to see the next name you entered.");
                }

                //close the file
                inputFile.Close();

            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

    }
}
