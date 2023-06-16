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
    public partial class Home_Work11 : Form
    {        
        public Home_Work11()
        {
            InitializeComponent();         
        }
        private int xVelocity = 10;
        private int yVelocity = 10;
        private void MoveImage()
        {
            pictureBox1.Location = new Point(pictureBox1.Left + xVelocity, pictureBox1.Top + yVelocity);

            if (pictureBox1.Left < 0 || pictureBox1.Right >= this.ClientSize.Width)
            {
                xVelocity = -xVelocity;
            }

            if (pictureBox1.Top < 0 || pictureBox1.Bottom >=this.ClientSize.Height)
            {
                yVelocity = -yVelocity;
            }
           
        }
        private void Home_Work11_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            MoveImage();
        }

        private Point initialPosition;
        private void Home_Work11_MouseMove(object sender, MouseEventArgs e)
        {
            // 計算滑鼠移動的距離
            int distance = Math.Abs(Cursor.Position.X - initialPosition.X) + Math.Abs(Cursor.Position.Y - initialPosition.Y);
            // 如果距離超過指定閾值，則關閉視窗
            if (distance >= 950)
            {
                Close();
            }
        }

        private void Home_Work11_KeyDown(object sender, KeyEventArgs e)
        {
            //Application.Exit();//按下任意鍵結束程序
            Close();
        }

        private void Home_Work11_MouseDown(object sender, MouseEventArgs e)
        {
            //this.Close();

        }
    }
    }
    

