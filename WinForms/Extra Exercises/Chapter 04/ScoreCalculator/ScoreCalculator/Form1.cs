using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        // class variable
        int total;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score;
            int.TryParse(txtScore.Text, out score);

            if (score > 0)
            {
                total += score;
                count++;
                txtTotal.Text = total.ToString();
                txtCount.Text = count.ToString();
                txtAverage.Text = (total / count).ToString();
            }
            txtScore.Focus();
            txtScore.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            count = 0;
            txtTotal.Text = "0";
            txtCount.Text = "0";
            txtAverage.Text = "0";
            txtScore.Text = "";
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnClear.PerformClick();
        }
    }
}
