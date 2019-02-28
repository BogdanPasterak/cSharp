using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddEvenNumber
{
    public partial class Form1 : Form
    {
        int[] odd, even;
        int count, countOdd, countEven;

        public Form1()
        {
            InitializeComponent();
            odd = new int[10];
            even = new int[10];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int value;
            if (txtNumber.Text == "" || !int.TryParse(txtNumber.Text, out value))
            {
                MessageBox.Show("Enter integer value", "Error");
                txtNumber.Clear();
                txtNumber.Focus();
            }
            else
            {
                if (value % 2 == 0)
                {
                    even[countEven++] = value;
                    ShowArray(true);
                }
                else
                {
                    odd[countOdd++] = value;
                    ShowArray(false);
                }

                count++;
                if (count == 10)
                {
                    MessageBox.Show("Ten Numbers", "End");
                    ShowArray(true);
                    ShowArray(false);
                    Close();
                }
                else
                {
                    txtNumber.Clear();
                    txtNumber.Focus();
                }
            }

        }

        private void ShowArray(bool boolEven)
        {
            string s = "";
            
            for (int i = 0; i < ((boolEven) ? countEven : countOdd) ; i++)
            {
                s += ((boolEven) ? even[i] : odd[i]).ToString() + "\n";
            }
            MessageBox.Show(s, ((boolEven) ? "Even Number" : "Odd Number"));
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ShowArray(true);
            ShowArray(false);
            txtNumber.Focus();
        }
    }
}
