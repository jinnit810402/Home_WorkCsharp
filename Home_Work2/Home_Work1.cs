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
    public partial class Home_Work1 : Form
    {
        public Home_Work1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name1 = txtName1.Text;
            string name2 = txtName2.Text;
            string name3 = txtName3.Text;
            string name4 = txtName4.Text;
            

            MessageBox.Show("Hello,我是" + name1 + Environment.NewLine +
                            "英文名字是" + name2 + Environment.NewLine +
                            "性別是" + name3 + Environment.NewLine +
                            "星座是" + name4 + Environment.NewLine +
                            "很高興認識你 。");

        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name1 = txtName1.Text;
            string name2 = txtName2.Text;
            string name3 = txtName3.Text;
            string name4 = txtName4.Text;


            MessageBox.Show("HI!,我是" + name1 + Environment.NewLine + "英文名字是" + name2 + Environment.NewLine + "性別是" + name3 + Environment.NewLine + "星座是" + name4 + Environment.NewLine + "很高興認識你 。");
        }

        private void Home_Work1_Load(object sender, EventArgs e)
        {

        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
