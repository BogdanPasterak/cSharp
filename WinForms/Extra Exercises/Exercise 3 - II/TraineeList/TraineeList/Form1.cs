using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraineeList
{
    public partial class Form1 : Form
    {
        string[] trainees;
        int count;
        public Form1()
        {
            InitializeComponent();
            trainees = new string[3];
            count = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter the name", "Error");
                txtName.Focus();
            }
            else if (count >= trainees.Length)
            {
                MessageBox.Show("Array is full", "Error");
                ShowArray();
                Close();
            }
            else
            {
                trainees[count] = txtName.Text;
                count++;
                ShowArray();
                txtName.Clear();
                txtName.Focus();
            }

        }

        private void ShowArray()
        {
            string s = "";
            for (int i = 0; i < count; i++)
            {
                s += trainees[i] + "\n";
            }
            MessageBox.Show(s, "Array Trainees");
        }
    }
}
