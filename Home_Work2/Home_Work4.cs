using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Home_Work2
{
    
    public partial class Home_Work4 : Form
    {
        string t_Name;
        int Chinese, English, Math;
        public Home_Work4()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            t_Name = txtName.Text;
            int.TryParse(txtChinese.Text, out Chinese);
            int.TryParse(txtEnglish.Text, out English);
            int.TryParse(txtMath.Text, out Math);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int highestScore = Chinese;
            string highestSubject = "國文";

            if (English > highestScore)
            {
                highestScore = English;
                highestSubject = "英文";
            }

            if (Math > highestScore)
            {
                highestScore = Math;
                highestSubject = "數學";
            }

            int lowestScore = Chinese;
            string lowestSubject = "國文";

            if (English < lowestScore)
            {
                lowestScore = English;
                lowestSubject = "英文";
            }

            if (Math < lowestScore)
            {
                lowestScore = Math;
                lowestSubject = "數學";
            }

            labHighAndLow.Text = $"最高科目成績: {highestSubject} {highestScore}分 \n最低科目成績: {lowestSubject} {lowestScore}分";


        }

        private void Home_Work4_Load(object sender, EventArgs e)
        {
            txtName.Text = "0";
            txtChinese.Text = "0";
            txtEnglish.Text = "0";
            txtMath.Text = "0";
        }

        private void btnShowValue_Click(object sender, EventArgs e)
        {
             labShowValue.Text = $"姓名: {t_Name}\n國文分數: {Chinese}\n英文分數: {English}\n數學分數: {Math}";
        }

       

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
