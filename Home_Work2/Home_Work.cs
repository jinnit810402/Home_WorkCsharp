using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home_Work2
{

    public partial class Home_Work : Form
    {
        public Home_Work()
        {
            InitializeComponent();
        }
        int n;
        private void Button1_Click(object sender, EventArgs e)

        {
            if (int.TryParse(textBox1.Text, out n))
            {
                if (n % 2 == 0)

                {
                    labshow.Text = $"輸入的數{n}為偶數";
                }
                else
                {
                    labshow.Text = $"輸入的數{n}為奇數";
                }

            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int[] intArray = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int intMax = intArray[0];
            int intMix = intArray[0];

            for (int ii = 0; ii < intArray.Length; ii++)
            {
                if (intMax < intArray[ii])
                {
                    intMax = intArray[ii];
                }

                if (intMix > intArray[ii])
                {
                    intMix = intArray[ii];
                }
                labshow.Text = $"int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + '\n'
                               + $"最大值為 {intMax}" + '\n'
                               + $"最小值為{intMix}";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int[] intArray = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int oddCount = 0;
            int evenCount = 0;

            foreach (int num in intArray)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                labshow.Text = $"int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + '\n'
                                  + $"奇數共 {oddCount}" + '\n'
                                  + $"偶數共 {evenCount}";
            }


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherafacker" };
            int count = 0;

            foreach (string str in arr0711_Str)
            {
                if (str.Contains("C") || str.Contains("c"))
                {
                    count++;
                }
            }
            labshow.Text = $"arr0711_Str陣列:     mother張    emma    迪克蕭    J40    Candy    Cindy    Coconut    Motherafacker " + '\n'
                                  + $"有C及c的名字共 {count}個";

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherafacker" };
            string longString = arr0711_Str[0];

            foreach (string str in arr0711_Str)
            {
                if (str.Length > longString.Length)
                {
                    longString = str;
                }
            }

            labshow.Text = $" arr0711_Str  [  mother張,emma,迪克蕭,J40,Candy,Cindy,Coconut,Motherafacker]" + '\n' +
                $"最長的字串:{longString}";




        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[,] {
           {1,1,1,1,1,1,1,1,1,1 },
           {1,0,0,0,0,0,0,0,0,1 },
           {1,0,0,0,0,0,0,0,0,1 },
           {1,0,0,0,0,0,0,0,0,1 },
           {1,0,0,0,0,0,0,0,0,1 },
           {1,0,0,0,0,0,0,0,0,1 },
           {1,0,0,0,0,0,0,0,0,1 },
           {1,0,0,0,0,0,0,0,0,1 },
           {1,0,0,0,0,0,0,0,0,1 },
           {1,1,1,1,1,1,1,1,1,1 }
            };
            string arrAll = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arrAll += arr[i, j] + " ";
                }

                arrAll += Environment.NewLine;//在每一行結束後換行
            }

            labshow.Text = arrAll;

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[,] {
           {0,0,0,0,0,0,0,0,0,0 },
           {0,1,1,1,1,1,1,1,1,0 },
           {0,1,1,1,1,1,1,1,1,0},
           {0,1,1,1,1,1,1,1,1,0},
           {0,1,1,1,1,1,1,1,1,0},
           {0,1,1,1,1,1,1,1,1,0},
           {0,1,1,1,1,1,1,1,1,0},
           {0,1,1,1,1,1,1,1,1,0},
           {0,1,1,1,1,1,1,1,1,0},
           {0,0,0,0,0,0,0,0,0,0 }
            };
            string arrAll = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arrAll += arr[i, j] + " ";
                }

                arrAll += Environment.NewLine;//在每一行結束後換行
            }

            labshow.Text = arrAll;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[,] {
           {1,0,1,0,1,0,1,0,1,0},
           {0,1,0,1,0,1,0,1,0,1},
           {1,0,1,0,1,0,1,0,1,0},
           {0,1,0,1,0,1,0,1,0,1},
           {1,0,1,0,1,0,1,0,1,0},
           {0,1,0,1,0,1,0,1,0,1},
           {1,0,1,0,1,0,1,0,1,0},
           {0,1,0,1,0,1,0,1,0,1},
           {1,0,1,0,1,0,1,0,1,0},
           {0,1,0,1,0,1,0,1,0,1}
            };
            string arrAll = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arrAll += arr[i, j] + " ";
                }

                arrAll += Environment.NewLine;//在每一行結束後換行
            }

            labshow.Text = arrAll;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            int txtfrom = int.Parse(textBox2.Text);
            int txtdo = int.Parse(textBox3.Text);
            int txtstep = int.Parse(textBox4.Text);

            int sum = 0;
            //我們使用 for 迴圈從 txtfrom 開始，每次以 txtstep 為增量進行累加。在每次迴圈中，我們將當前的數值 i 加到 sum 變數中。
            //最後，我們將結果顯示在 labshow.Text 中，以顯示起始值、終止值的間隔和加總結果。
            for (int i = txtfrom; i <= txtdo; i += txtstep)
            {
                sum += i;
            }

            labshow.Text = textBox2.Text + " 到 " + textBox3.Text + " 相隔 " + (txtstep - 1) + '\n' + "加總為 " + sum.ToString();

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            int txtfrom = int.Parse(textBox2.Text);
            int txtdo = int.Parse(textBox3.Text);
            int txtstep = int.Parse(textBox4.Text);

            int sum = 0;
            int currentNumber = txtfrom;

            while (currentNumber <= txtdo)
            {
                sum += currentNumber;
                currentNumber += txtstep;
            }
            labshow.Text = textBox2.Text + " 到 " + textBox3.Text + " 相隔 " + (txtstep - 1) + '\n' + "加總為 " + sum.ToString();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            int txtfrom = int.Parse(textBox2.Text);
            int txtdo = int.Parse(textBox3.Text);
            int txtstep = int.Parse(textBox4.Text);

            int sum = 0;
            int currentNumber = txtfrom;

            do
            {
                sum += currentNumber;
                currentNumber += txtstep;
            } while (currentNumber <= txtdo);

            labshow.Text = textBox2.Text + " 到 " + textBox3.Text + " 相隔 " + (txtstep - 1) + '\n' + "加總為 " + sum.ToString();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            int[] intArray = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = intArray.Sum();

            labshow.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + '\n'
                                  + $"加總為  {sum}";

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            int[] intArray = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int intMax = intArray[0];


            for (int ii = 0; ii < intArray.Length; ii++)
            {
                if (intMax < intArray[ii])
                {
                    intMax = intArray[ii];
                }


                labshow.Text = $"int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + '\n'
                               + $"最大值為 {intMax}";

            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            int[] intArray = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int intMix = intArray[0];

            for (int ii = 0; ii < intArray.Length; ii++)
            {


                if (intMix > intArray[ii])
                {
                    intMix = intArray[ii];
                }
                labshow.Text = $"int陣列arr0711[1,5,6,8,7,97,54,887,65,578]" + '\n'
                             + $"最小值為{intMix}";
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            labshow.Text = $"換位前 n1={n1},n2={n2}\n";

            Swap(ref n1, ref n2);
            labshow.Text += $"換位後 n1={n1},n2={n2}";
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            labshow.Text = "結果";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            int num = 100;
            string binary = Convert.ToString(num, 2);
            labshow.Text = binary;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            string input = textBox5.Text;
            int layers;
            bool isNumeric = int.TryParse(input, out layers);

            if (isNumeric)
            {
                labshow.Text = "";

                for (int i = 0; i < layers; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        labshow.Text += ("*");

                    }

                    labshow.Text += '\n';

                }

            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }



        private void button19_Click(object sender, EventArgs e)
        {
            int i,j = 2;
            labshow.Text = "";
            labshow.Text += "九九乘法表\n";
            for ( i = 2; i <= 9; i++)
            {


                for ( j = 2; j <= 9; j++) 
                {
                    
                    labshow.Text += ($"{i}x{j}={i * j:00}。");
                    
                }

                labshow.Text += $"\n";
            }

            labshow.Text += $"\n";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            for (int ctr = 1; ctr < 50; ctr++)
            {
                labshow.Text=($"樂透號碼\n{rnd.Next(0, 50)},{rnd.Next(0, 50)},{rnd.Next(0, 50)},{rnd.Next(0, 50)},{rnd.Next(0, 50)},{rnd.Next(0, 50)}");
            }
        }
    }
}
