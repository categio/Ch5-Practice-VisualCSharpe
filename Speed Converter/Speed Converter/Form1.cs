using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Speed_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //const variables
            const int START_SPEED = 50;
            const int END_SPEED = 140;
            const int INTERVAL = 10;
            const double CONV_FACTOR = 0.6124;

            //variables
            int kph; //kilometers per hour
            double mph; //miles per hour

            //Display the speed conversions to the ListBox
            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                //calc mph
                mph = kph * CONV_FACTOR;

                //display conversion
                outputListBox.Items.Add(kph + "kph is the same as " +
                    mph + " mph");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear list box
            outputListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form/program
            this.Close();
        }
    }
}
