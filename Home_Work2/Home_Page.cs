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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
            button6.Enabled = false;
            button7.Enabled = false;
            
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }
        public void frmCall(Form frm)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            //非最上層
            frm.TopLevel = false;

            //顯示Form，要加上去才會顯示Form
            frm.Visible = true;

            //設定Form位置
            frm.Top = 0;
            frm.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Home_Work1 frm = new Home_Work1();
            frmCall(frm);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_work2 frm2 = new Home_work2();
            frmCall(frm2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home_Work3 frm3 = new Home_Work3();
            frmCall(frm3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Work4 frm4 = new Home_Work4();
            frmCall(frm4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Home_Work5 frm05 = new Home_Work5();
            frmCall(frm05);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Home_Work8 frm8 = new Home_Work8();
            frmCall(frm8);
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            Home_Work frm09 = new Home_Work();
            frmCall(frm09);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Home_Work10 frm10 = new Home_Work10();
            frmCall(frm10);
        }

        

       

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Home_Work11 frm11 = new Home_Work11();
            frm11.Show();
        }

       
    }
}
