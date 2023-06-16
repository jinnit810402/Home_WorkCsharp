using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Work2
{

    public partial class Home_Work8 : Form
    {
        public Home_Work8()
        {
            InitializeComponent();
        }
        
        

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double result = num1 - num2;
                labAnswer.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void Btntimes_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double result = num1 * num2;
                labAnswer.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void BtnDivided_By_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double result = num1 / num2;
                labAnswer.Text = result.ToString(("F4"));
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void TxtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Work8_Load(object sender, EventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double result = num1 + num2;
                labAnswer.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
    }
    }


