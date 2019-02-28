using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayNumber
{
    public partial class Form1 : Form
    {
        int[] arrayInt;
        int count;

        public Form1()
        {
            InitializeComponent();
            arrayInt = new int[7];
            count = 0;
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
                arrayInt[count] = value;
                count++;
                if (count == arrayInt.Length)
                {
                    MessageBox.Show("Array is full!", "Error");
                    ShowArray();
                    Close();
                }
                else
                {
                    txtNumber.Clear();
                    txtNumber.Focus();
                }
            }

        }

        private void ShowArray()
        {
            string s = "";
            for (int i = count - 1; i >= 0; i--)
            {
                s += arrayInt[i].ToString() + "\n";
            }
            MessageBox.Show(s, "Array");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ShowArray();
            txtNumber.Focus();
        }
    }
}
