using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home_Work2
{
    
    public partial class Home_work2 : Form
    {
        int loanAmount, loanTerm, downPayment, numberOfPayments;
        double annualInterestRate, averageMonthlyPayment, totalPayment, averageAmortizationRate, monthlyInterestRate, totalPayment2, averageMonthlyPayment2;

        private void Home_work2_Load(object sender, EventArgs e)
        {

        }

        private void loanTermTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pay();
            MessageBox.Show("月付額：" + averageMonthlyPayment2 + "元");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pay();
            MessageBox.Show("總共付：" + totalPayment2 + "元");
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Home_workjimp f2 = new Home_workjimp();
            pay();
            f2.Value1 = loanAmountTextBox.Text;
            f2.Value2 = loanTermTextBox.Text;
            f2.Value3 = annualInterestRate.ToString();
            
            f2.Value4 = averageMonthlyPayment2.ToString();
            f2.Value5 = totalPayment2.ToString();
            f2.ShowDialog();
            
            
        }

        public Home_work2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void pay()
        {
             loanAmount = Convert.ToInt32(loanAmountTextBox.Text);
             loanTerm = Convert.ToInt32(loanTermTextBox.Text);
             annualInterestRate = Convert.ToDouble(interestRateTextBox.Text);
             downPayment = Convert.ToInt32(downPaymentTextBox.Text);
            // 將年利率換成月利率
             monthlyInterestRate = annualInterestRate / 12 / 100;

            // 計算還款月數
             numberOfPayments = loanTerm * 12;

            // 計算利率
             averageAmortizationRate = (Math.Pow(1 + monthlyInterestRate, numberOfPayments) * monthlyInterestRate) /
                                              (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);

            // 計算月付
             averageMonthlyPayment = loanAmount * averageAmortizationRate;
            //計算跟總金額
             totalPayment = averageMonthlyPayment * numberOfPayments;

            averageMonthlyPayment2 = (int)averageMonthlyPayment;
            totalPayment2 = (int)totalPayment;
        }


        }
    }



