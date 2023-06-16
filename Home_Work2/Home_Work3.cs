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
    public partial class Home_Work3 : Form
    {
        int dish1Count, dish2Count, dish3Count, dish4Count;
        decimal totalMenuPrice;
        decimal unitPrice = 120;
        decimal unitPrice2 = 180;
        decimal unitPrice3 = 190;
        decimal unitPrice4 = 200;
        string[] orderItems = new string[4];
        public Home_Work3()
        {
            InitializeComponent();
            dataGridView.Columns.Add("menu", "菜單");
            dataGridView.Columns.Add("count", "數量");
            dataGridView.Columns.Add("price", "價格");
            

            /// 設置 dataGridView顯示樣式
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            


        }
       
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtTotalPrice.Text = $"總金額：NT$: {totalMenuPrice} ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDish1_Click(object sender, EventArgs e)
        {
            dish1Count++;
            UpdateMenu();
            
        }

        private void btnDish2_Click(object sender, EventArgs e)
        {
            dish2Count++;
            UpdateMenu();
        }

        private void btnDish3_Click(object sender, EventArgs e)
        {
            dish3Count++;
            UpdateMenu();
        }

        private void btnDish4_Click(object sender, EventArgs e)
        {
            dish4Count++;
            UpdateMenu();
        }

        private void Home_Work2_Load(object sender, EventArgs e)
        {
            totalMenuPrice = 0; 
            txtTotalPrice.Text = $"NT$: {totalMenuPrice}";

            
            btnDish1.Text = ("黑啤 blackbeer NT$120");
            btnDish2.Text = ("可樂娜 colabeer NT$180");
            btnDish3.Text = ("藍啤 bluebeer NT$190");
            btnDish4.Text = ("酷啤 coolbeer NT$200");
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            DialogResult  CashResult;
            if (totalMenuPrice == 0)
            {
                CashResult = MessageBox.Show("尚未點餐" , "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                CashResult = MessageBox.Show($"總金額：NT$: {totalMenuPrice} ", "確認付款", MessageBoxButtons.YesNo);
            }
            

        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            DialogResult CardResult;
            decimal discountedPrice = totalMenuPrice * 0.9m;
            discountedPrice = (int)discountedPrice;
            if (totalMenuPrice == 0)
            {
                CardResult = MessageBox.Show("尚未點餐" , "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                CardResult = MessageBox.Show($"總金額：NT$: {totalMenuPrice} " + "\n" + $"折扣後金額：NT$: {discountedPrice} ", "確認付款", MessageBoxButtons.YesNo);
            }
            
            
            
        }

        private void txtList_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCleanList_Click(object sender, EventArgs e)
        {
            dish1Count = 0;
            dish2Count = 0;
            dish3Count = 0;
            dish4Count = 0;
            
            dataGridView.Rows.Clear();
            UpdateTotalPrice();
        }
        private void UpdateMenu()
        {


            dataGridView.Rows.Clear();

            // 購物清單
            decimal totalPrice = dish1Count * unitPrice;
            decimal totalPrice2 = dish2Count * unitPrice2;
            decimal totalPrice3 = dish3Count * unitPrice3;
            decimal totalPrice4 = dish4Count * unitPrice4;


            orderItems[0] = $"黑啤 blackbeer X{dish1Count}，共NT$: {totalPrice} ";
            orderItems[1] = $"可樂娜 colabeer X{dish2Count}，共NT$: {totalPrice2} ";
            orderItems[2] = $"藍啤 bluebeer X{dish3Count}，共NT$: {totalPrice3} ";
            orderItems[3] = $"酷啤 coolbeer X{dish4Count}，共NT$: {totalPrice4} ";


            //string order1 = $"黑啤 blackbeer X{dish1Count}，共NT$: {totalPrice} ";
            //string order2 = $"可樂娜 colabeer X{dish2Count}，共NT$: {totalPrice2} ";
            //string order3 = $"藍啤 bluebeer X{dish3Count}，共NT$: {totalPrice3} ";
            //string order4 = $"酷啤 coolbeer X{dish4Count}，共NT$: {totalPrice4} ";
            /*建立陣列將每一個物品的文字儲存再陣列[0][1][2][3]
              string一個變數 將每個陣列的文字儲存再這個變數
              再將這個變數內容顯示再textbox*/

           

            if (dish1Count > 0)
                dataGridView.Rows.Add("黑啤 blackbeer", dish1Count, $"NT$: {totalPrice} ");
            if (dish2Count > 0)
                dataGridView.Rows.Add("可樂娜 colabeer", dish2Count, $"NT$: {totalPrice2} ");
            if (dish3Count > 0)
                dataGridView.Rows.Add("藍啤 bluebeer", dish3Count, $"NT$: {totalPrice3} ");
            if (dish4Count > 0)
                dataGridView.Rows.Add("酷啤 coolbeer", dish4Count, $"NT$: {totalPrice4} ");

            

            UpdateTotalPrice();


            txtTotalPrice.Text = $"NT$: {totalMenuPrice}";
        }
        private void UpdateTotalPrice()
        {
            //重新計算讓總金額歸0的方法
            totalMenuPrice = dish1Count * unitPrice + dish2Count * unitPrice2 + dish3Count * unitPrice3 + dish4Count * unitPrice4;
            txtTotalPrice.Text = $"總金額：NT$: {totalMenuPrice} ";
        }
    }
    
}
