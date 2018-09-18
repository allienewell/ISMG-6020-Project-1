using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /***************************************
            * this method calculates the letter 
            * grade based on the number grade 
            * entered
            * **************************************/

            //get the number grade from the NumberGrade text box
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);

            //declaring and initializing the variable that will hold the letter grade
            string letterGrade = "";

            //sets the parameters for the letter grade
            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            //displays letter grade in LetterGrade text box
            txtLetterGrade.Text = letterGrade;

            //move focus back to NumberGrade text box 
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
