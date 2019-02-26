using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0;

            switch (operator1)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    result = operand1 / operand2;
                    break;
            }

            return result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string op1 = txtOperand1.Text;
            string op2 = txtOperand2.Text;
            string op = txtOperator.Text;
            decimal num1, num2, result;

            // validate imputs
            if ("+-*/".Contains(op) && op.Length == 1 &&
                decimal.TryParse(op1, out num1) &&
                decimal.TryParse(op2, out num2))
            {
                try
                {
                    result = Calculate(num1, op, num2);
                    txtResult.Text = result.ToString("n4");
                }
                catch (Exception)
                {
                    txtResult.Text = "Error";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
