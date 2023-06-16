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

    public partial class Home_Work10 : Form
    {
        private bool isCrossTurn = true;
        private bool isGameFinished = false;
        public Home_Work10()
        {
            InitializeComponent();
        }
        

        private void Home_Work10_Load(object sender, EventArgs e)
        {
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
            this.KeyPreview = true;


        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (isGameFinished)
                return;

            Button button = (Button)sender;
            if (button.Text != "")
                return;

            if (isCrossTurn)
                button.Text = "X";
            else
                button.Text = "O";

            isCrossTurn = !isCrossTurn;

            CheckForWinner();
        }

        private void CheckForWinner()
        {
            // 檢查是否有玩家獲勝
            if (CheckLine(button1, button2, button3) ||
                CheckLine(button4, button5, button6) ||
                CheckLine(button7, button8, button9) ||
                CheckLine(button1, button4, button7) ||
                CheckLine(button2, button5, button8) ||
                CheckLine(button3, button6, button9) ||
                CheckLine(button1, button5, button9) ||
                CheckLine(button3, button5, button7))
            {
                string winner = isCrossTurn ? "O" : "X";
                MessageBox.Show("玩家 " + winner + " 獲勝！");
                isGameFinished = true;
                ResetGame();
            }
            // 檢查平局
            //9個按鈕皆檢查是否不是空值,若條件都為真就是平局
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                     button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                     button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("平局！");
                isGameFinished = true;
                ResetGame();
            }
        }

        private bool CheckLine(Button button1, Button button2, Button button3)
        //A&& B,當A、B都為真時，結果才會為真
        {
            return button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text;
        }



        private void ResetGame()
        {
            isCrossTurn = true;
            isGameFinished = false;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Work10_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.R)
            {
                ResetGame();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
