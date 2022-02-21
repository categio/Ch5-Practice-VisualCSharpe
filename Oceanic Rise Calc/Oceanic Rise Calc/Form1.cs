using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oceanic_Rise_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //const variable for rise level in ml
            const double MM_RATE = 40.64;
            //variables for incremented data
            int yr = 1;
            //double mlRisen = yr * MLM_RATE; 
            //considering adding user input for years in an edit

            while (yr <= 10)
            {
                for (yr = 1; yr <= 10; yr++)
                {
                    oceanicRiseListBox.Items.Add("At year " + yr +
                        ", the total millimeters the ocean will have risen is "
                        + (yr * MM_RATE) + "mm.");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear data in the listbox
            oceanicRiseListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
