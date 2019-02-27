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
        int[] scores;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score, total = 0, average;

            int.TryParse(txtScore.Text, out score);

            if (score > 0 && score <= 100 )
            {
                if (count < 20) {
                    scores[count] = score;
                    count++;
                    foreach (int item in scores)
                    {
                        total += item;
                    }
                    average = total / count;
                    txtTotal.Text = total.ToString();
                    txtCount.Text = count.ToString();
                    txtAverage.Text = average.ToString();
                }
            }
            txtScore.Focus();
            txtScore.SelectAll();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int[] view = new int[count];
            Array.Copy(scores, view, count);
            Array.Sort(view);

            string display = "";
            foreach (int item in view)
            {
                display += item.ToString() + "\n";
            }
            MessageBox.Show(display, "Sorted Scores");
            txtScore.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            scores = new int[20];
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
