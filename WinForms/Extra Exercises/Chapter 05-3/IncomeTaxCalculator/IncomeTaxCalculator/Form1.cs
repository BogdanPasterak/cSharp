using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeTaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double income;
            double.TryParse(txtIncome.Text, out income);

            double tax = CalculateTax(income);

            txtTax.Text = tax.ToString("c");
            txtIncome.SelectAll();
        }

        private static double CalculateTax(double income)
        {
            double tax;
            if (income >= 413200)
                tax = (income - 413200) * .396 + 119996.25;
            else if (income >= 411500)
                tax = (income - 411500) * .35 + 119401.25;
            else if (income >= 189300)
                tax = (income - 189300) * .33 + 46075.25;
            else if (income >= 90750)
                tax = (income - 90750) * .28 + 18481.25;
            else if (income >= 37450)
                tax = (income - 37450) * .25 + 5156.25;
            else if (income >= 9225)
                tax = (income - 9225) * .15 + 922.5;
            else if (income >= 0)
                tax = income * .1;
            else
                tax = 0;
            return tax;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {
            txtTax.Text = "";
        }
    }
}
