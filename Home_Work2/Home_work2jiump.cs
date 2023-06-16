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
    public partial class Home_workjimp : Form
    {
        public string Value1;
        public string Value2; 
        public string Value3;
        public string Value4;
        public string Value5;
        public Home_workjimp()
        {
            InitializeComponent();
        }
        public string str;
        private void FrmJump2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Value1;
            textBox2.Text = Value2;
            textBox3.Text = Value3;
            textBox4.Text = Value4;
            textBox5.Text = Value5;
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
