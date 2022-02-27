using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newBasicCalculator
{
    public partial class basicCalculator : Form
    {
        
        public basicCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(txtNumber1.Text);
            var num2 = Convert.ToDouble(txtNumber2.Text);
          var sum = num1 + num2;
            lblResultDisplay.Text = sum.ToString();
            btnAdd.Visible = false;
            btnDivide.Visible = true;
  
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(txtNumber1.Text);
            var num2 = Convert.ToDouble(txtNumber2.Text);

            var difference = num1 - num2;
            lblResultDisplay.Text = difference.ToString();
            btnMinus.Visible = false;
            btnAdd.Visible = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(txtNumber1.Text);
            var num2 = Convert.ToDouble(txtNumber2.Text);

            var product = num1 * num2;
            lblResultDisplay.Text = product.ToString();
            btnMultiply.Visible = false;
            btnMinus.Visible = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(txtNumber1.Text);
            var num2 = Convert.ToDouble(txtNumber2.Text);

            var quotient = num1 / num2;
            lblResultDisplay.Text = quotient.ToString();
            btnDivide.Visible = false;
            btnMultiply.Visible = true;
        }
    }
    
}
