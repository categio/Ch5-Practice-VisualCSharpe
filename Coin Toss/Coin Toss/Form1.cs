using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //holds value of coin side up
            int sideUp;

            //create Random obj
            Random rand = new Random();

            //get random int in range of 0-7
            //Even = tails
            //Odd = heads
            sideUp = rand.Next(7);

            //display side that should be up
            if (sideUp == 0 || sideUp == 2 || sideUp == 4 || sideUp == 6)
            {
                //display tails
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                //heads
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form/program
            this.Close();
        }
    }
}
