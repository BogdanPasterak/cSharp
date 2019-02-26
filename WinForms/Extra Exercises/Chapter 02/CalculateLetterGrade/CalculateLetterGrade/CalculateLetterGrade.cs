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
    public partial class CalculateLetterGrade : Form
    {
        public CalculateLetterGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);
            string letterGrade = "";

            if (numberGrade >= 88)
                letterGrade = "A";
            else if (numberGrade >= 80)
                letterGrade = "B";
            else if (numberGrade >= 68)
                letterGrade = "C";
            else if (numberGrade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            txtLetterGrade.Text = letterGrade;
            txtNumberGrade.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
