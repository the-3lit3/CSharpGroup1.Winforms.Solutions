using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinformCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(number1.Text);
            var num2 = Convert.ToDouble(number2.Text);
            var sum = (num1 + num2);

            result.Text = sum.ToString();
            add.Visible = false;
            divide.Visible = true;


        }

        private void minus_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(number1.Text);
            var num2 = Convert.ToDouble(number2.Text);
            var difference = num1 - num2;

            result.Text = difference.ToString();
            minus.Visible = false;
            add.Visible = true;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(number1.Text);
            var num2 = Convert.ToDouble(number2.Text);
            var product = num1 * num2;

            result.Text = product.ToString();
            mult.Visible = false;
            minus.Visible = true;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(number1.Text);
            var num2 = Convert.ToDouble(number2.Text);
            var quotient = num1 / num2;

            result.Text = quotient.ToString();
            divide.Visible = false;
            mult.Visible=true;
        }
    }
}
