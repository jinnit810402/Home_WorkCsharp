using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Home_Work2
{
    public partial class Home_Work5 : Form
    {
        private List<Student> students;
        public Home_Work5()
        {
            InitializeComponent();
            students = new List<Student>();
            listViewResults.View = View.Details;
            listViewResults.Columns.Add("姓名");
            listViewResults.Columns.Add("國文");
            listViewResults.Columns.Add("英文");
            listViewResults.Columns.Add("數學");
            listViewResults.Columns.Add("總分");
            listViewResults.Columns.Add("平均");
            listViewResults.Columns.Add("最低分", 80);
            listViewResults.Columns.Add("最高分", 80);


        }



        private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStudentAdd_Click_1(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;

            int chi = 0; int eng = 0; int math = 0;
            bool isNum = int.TryParse(textBoxChinese.Text, out chi);
            bool isNum1 = int.TryParse(textBoxEnglish.Text, out eng);
            bool isNum2 = int.TryParse(textBoxMath.Text, out math);
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("請輸入姓名", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!isNum)
            {

                MessageBox.Show("請輸入國文成績", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isNum1)
            {
                MessageBox.Show("請輸入英文成績", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isNum2)
            {
                MessageBox.Show("請輸入數學成績", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isNum && isNum1 && isNum2)
            {
                string name = textBoxName.Text;
                float chineseScore = chi;
                float englishScore = eng;
                float mathScore = math;






                students.Add(new Student(name, chineseScore, englishScore, mathScore));

                float totalScore = chineseScore + englishScore + mathScore;
                float averageScore = totalScore / 3;
                float lowestScore = Math.Min(chineseScore, Math.Min(englishScore, mathScore));
                float highestScore = Math.Max(chineseScore, Math.Max(englishScore, mathScore));

                ListViewItem studentItem = new ListViewItem(name);
                studentItem.SubItems.Add(chineseScore.ToString());
                studentItem.SubItems.Add(englishScore.ToString());
                studentItem.SubItems.Add(mathScore.ToString());
                studentItem.SubItems.Add(totalScore.ToString());
                studentItem.SubItems.Add(averageScore.ToString());
                studentItem.SubItems.Add(lowestScore.ToString());
                studentItem.SubItems.Add(highestScore.ToString());

                string lowestSubject = "";
                if (lowestScore == chineseScore)
                    lowestSubject = "國文";
                else if (lowestScore == englishScore)
                    lowestSubject = "英文";
                else if (lowestScore == mathScore)
                    lowestSubject = "數學";

                string highestSubject = "";
                if (highestScore == chineseScore)
                    highestSubject = "國文";
                else if (highestScore == englishScore)
                    highestSubject = "英文";
                else if (highestScore == mathScore)
                    highestSubject = "數學";

                ListViewItem studentItem2 = new ListViewItem(name);
                studentItem2.SubItems.Add(chineseScore.ToString("0.##"));
                studentItem2.SubItems.Add(englishScore.ToString("0.##"));
                studentItem2.SubItems.Add(mathScore.ToString("0.##"));
                studentItem2.SubItems.Add(totalScore.ToString("0.##"));
                studentItem2.SubItems.Add(averageScore.ToString("0.#"));
                studentItem2.SubItems.Add($"({lowestSubject}) {lowestScore.ToString("0.##")}");
                studentItem2.SubItems.Add($"({highestSubject}) {highestScore.ToString("0.##")}");



                listViewResults.Items.Add(studentItem2);
            }

        }

        private int currentNameNumber = 0;

        private string GenerateRandomName()
        {
            currentNameNumber++;

            return currentNameNumber.ToString();
        }


        private int[] GenerateRandomScores()
        {
            Random random = new Random();
            int[] scores = new int[3];
            HashSet<int> uniqueScores = new HashSet<int>(); // 使用 HashSet 來確保分數唯一

            while (uniqueScores.Count < 3)
            {
                int score = random.Next(101); // 生成0到100之間的隨機整數

                // 如果分數已存在，重新生成
                if (!uniqueScores.Contains(score))
                {
                    uniqueScores.Add(score);
                }
            }

            scores = uniqueScores.ToArray();
            return scores;
        }
        private string GetSubject(float score)
        {
            if (score == students.Last().ChineseScore)
                return "國文";
            else if (score == students.Last().EnglishScore)
                return "英文";
            else if (score == students.Last().MathScore)
                return "數學";

            return "";
        }

        private void btnAddRandomData_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
            string name = GenerateRandomName();
            int[] randomScores = GenerateRandomScores();

            float chineseScore = randomScores[0];
            float englishScore = randomScores[1];
            float mathScore = randomScores[2];
            //float chineseScore = GenerateRandomScore();
            //float englishScore = GenerateRandomScore();
            //float mathScore = GenerateRandomScore();


            students.Add(new Student(name, chineseScore, englishScore, mathScore));

            //  計算總分和平均分
            float totalScore = chineseScore + englishScore + mathScore;
            float averageScore = totalScore / 3;

            // 計算最低分和最高分
            float lowestScore = Math.Min(chineseScore, Math.Min(englishScore, mathScore));
            float highestScore = Math.Max(chineseScore, Math.Max(englishScore, mathScore));

            ListViewItem studentItem = new ListViewItem(name);
            studentItem.SubItems.Add(chineseScore.ToString("0.##"));
            studentItem.SubItems.Add(englishScore.ToString("0.##"));
            studentItem.SubItems.Add(mathScore.ToString("0.##"));
            studentItem.SubItems.Add(totalScore.ToString("0.##"));
            studentItem.SubItems.Add(averageScore.ToString("0.#"));
            studentItem.SubItems.Add($"({GetSubject(lowestScore)}) {lowestScore.ToString("0.##")}");
            studentItem.SubItems.Add($"({GetSubject(highestScore)}) {highestScore.ToString("0.##")} ");







            listViewResults.Items.Add(studentItem);
        }

        public class Student
        {
            public string Name { get; set; }
            public float ChineseScore { get; set; }
            public float EnglishScore { get; set; }
            public float MathScore { get; set; }
            //public float TotalScore => ChineseScore + EnglishScore + MathScore; 可運行

            public Student(string name, float chineseScore, float englishScore, float mathScore)
            {
                Name = name;
                ChineseScore = chineseScore;
                EnglishScore = englishScore;
                MathScore = mathScore;
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            btnStudentAdd.Enabled = false;
            btnAddRandomData.Enabled = false;
            btnCalculate.Enabled = false;
            btnAddRandom20.Enabled = false;


            float chineseTotalSum = 0;
            float englishTotalSum = 0;
            float mathTotalSum = 0;

            float chineseLowestScore = float.MaxValue;
            float chineseHighestScore = float.MinValue;

            float englishLowestScore = float.MaxValue;
            float englishHighestScore = float.MinValue;

            float mathLowestScore = float.MaxValue;
            float mathHighestScore = float.MinValue;

            int studentCount = listViewResults.Items.Count;

            foreach (ListViewItem item in listViewResults.Items)
            {
                float chineseScore = float.Parse(item.SubItems[1].Text);
                float englishScore = float.Parse(item.SubItems[2].Text);
                float mathScore = float.Parse(item.SubItems[3].Text);

                chineseTotalSum += chineseScore;
                englishTotalSum += englishScore;
                mathTotalSum += mathScore;

                chineseLowestScore = Math.Min(chineseLowestScore, chineseScore);
                chineseHighestScore = Math.Max(chineseHighestScore, chineseScore);

                englishLowestScore = Math.Min(englishLowestScore, englishScore);
                englishHighestScore = Math.Max(englishHighestScore, englishScore);

                mathLowestScore = Math.Min(mathLowestScore, mathScore);
                mathHighestScore = Math.Max(mathHighestScore, mathScore);
            }

            float chineseAverageScore = chineseTotalSum / studentCount;
            float englishAverageScore = englishTotalSum / studentCount;
            float mathAverageScore = mathTotalSum / studentCount;


            listViewResults2.Items.Clear();

            listViewResults2.Items.Add($"總分\n  平均\n最高分\n最低分");
            ListViewItem chineseItem = new ListViewItem();
            chineseItem.SubItems.Add(chineseTotalSum.ToString());
            chineseItem.SubItems.Add(chineseAverageScore.ToString("0.#"));
            chineseItem.SubItems.Add(chineseLowestScore.ToString());
            chineseItem.SubItems.Add(chineseHighestScore.ToString());
            listViewResults2.Items.Add(($"{chineseTotalSum}\n{chineseAverageScore}\n{chineseHighestScore}\n{chineseLowestScore}"));

            ListViewItem englishItem = new ListViewItem();
            englishItem.SubItems.Add(englishTotalSum.ToString());
            englishItem.SubItems.Add(englishAverageScore.ToString("0.#"));
            englishItem.SubItems.Add(englishLowestScore.ToString());
            englishItem.SubItems.Add(englishHighestScore.ToString());
            listViewResults2.Items.Add(($"{englishTotalSum}\n{englishAverageScore}\n{englishHighestScore}\n{englishLowestScore}"));

            ListViewItem mathItem = new ListViewItem();
            mathItem.SubItems.Add(mathTotalSum.ToString());
            mathItem.SubItems.Add(mathAverageScore.ToString("0.#"));
            mathItem.SubItems.Add(mathLowestScore.ToString());
            mathItem.SubItems.Add(mathHighestScore.ToString());
            listViewResults2.Items.Add(($"{mathTotalSum}\n{mathAverageScore}\n{mathHighestScore}\n{englishLowestScore}"));


        }

        private void listViewResults2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStudentAdd.Enabled = true;
            btnAddRandomData.Enabled = true;
            btnAddRandom20.Enabled = true;
            listViewResults.Items.Clear();
            listViewResults2.Items.Clear();
        }


        private void btnAddRandom20_Click(object sender, EventArgs e)
        {
            HashSet<string> usedNames = new HashSet<string>();
            List<int[]> usedScores = new List<int[]>();

            Random random = new Random();

            while (usedNames.Count < 20)
            {
                string name = GenerateRandomName();
                int[] randomScores;

                
                do
                {
                    randomScores = new int[3];
                    randomScores[0] = random.Next(0, 101);  // Chinese score range: 0-100
                    randomScores[1] = random.Next(0, 101);  // English score range: 0-100
                    randomScores[2] = random.Next(0, 101);  // Math score range: 0-100
                } while (usedScores.Any(s => s.SequenceEqual(randomScores)));

                float chineseScore = randomScores[0];
                float englishScore = randomScores[1];
                float mathScore = randomScores[2];

                students.Add(new Student(name, chineseScore, englishScore, mathScore));

                
                float totalScore = chineseScore + englishScore + mathScore;
                float averageScore = totalScore / 3;

               
                float lowestScore = Math.Min(chineseScore, Math.Min(englishScore, mathScore));
                float highestScore = Math.Max(chineseScore, Math.Max(englishScore, mathScore));

                ListViewItem studentItem = new ListViewItem(name);
                studentItem.SubItems.Add(chineseScore.ToString("0.##"));
                studentItem.SubItems.Add(englishScore.ToString("0.##"));
                studentItem.SubItems.Add(mathScore.ToString("0.##"));
                studentItem.SubItems.Add(totalScore.ToString("0.##"));
                studentItem.SubItems.Add(averageScore.ToString("0.#"));
                studentItem.SubItems.Add($"({GetSubject(lowestScore)}) {lowestScore.ToString("0.##")}");
                studentItem.SubItems.Add($"({GetSubject(highestScore)}) {highestScore.ToString("0.##")}");

                listViewResults.Items.Add(studentItem);
                usedNames.Add(name);
                usedScores.Add(randomScores);
            }

        }
    }
}