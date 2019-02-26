using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal length, width;
            decimal.TryParse(txtLength.Text, out length);
            decimal.TryParse(txtWidth.Text, out width);

            txtArea.Text = (length * width).ToString();
            txtPerimeter.Text = (2 * (length + width)).ToString();
            txtLength.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
