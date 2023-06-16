namespace Home_Work2
{
    partial class Home_Work5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxChinese = new System.Windows.Forms.TextBox();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.btnAddRandomData = new System.Windows.Forms.Button();
            this.listViewResults2 = new System.Windows.Forms.ListView();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnAddRandom20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(64, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxChinese
            // 
            this.textBoxChinese.Location = new System.Drawing.Point(64, 67);
            this.textBoxChinese.Name = "textBoxChinese";
            this.textBoxChinese.Size = new System.Drawing.Size(100, 22);
            this.textBoxChinese.TabIndex = 5;
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(64, 94);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnglish.TabIndex = 6;
            // 
            // textBoxMath
            // 
            this.textBoxMath.Location = new System.Drawing.Point(63, 127);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(100, 22);
            this.textBoxMath.TabIndex = 7;
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(17, 178);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(90, 23);
            this.btnStudentAdd.TabIndex = 8;
            this.btnStudentAdd.Text = "加入學生資料";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(17, 274);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "各科統計";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // listViewResults
            // 
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(193, 24);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(578, 244);
            this.listViewResults.TabIndex = 12;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddRandomData
            // 
            this.btnAddRandomData.Location = new System.Drawing.Point(17, 208);
            this.btnAddRandomData.Name = "btnAddRandomData";
            this.btnAddRandomData.Size = new System.Drawing.Size(90, 28);
            this.btnAddRandomData.TabIndex = 13;
            this.btnAddRandomData.Text = "隨機儲存資料";
            this.btnAddRandomData.UseVisualStyleBackColor = true;
            this.btnAddRandomData.Click += new System.EventHandler(this.btnAddRandomData_Click);
            // 
            // listViewResults2
            // 
            this.listViewResults2.HideSelection = false;
            this.listViewResults2.Location = new System.Drawing.Point(193, 274);
            this.listViewResults2.Name = "listViewResults2";
            this.listViewResults2.Size = new System.Drawing.Size(578, 164);
            this.listViewResults2.TabIndex = 14;
            this.listViewResults2.UseCompatibleStateImageBehavior = false;
            this.listViewResults2.SelectedIndexChanged += new System.EventHandler(this.listViewResults2_SelectedIndexChanged);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(13, 358);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(108, 23);
            this.btnClearScores.TabIndex = 15;
            this.btnClearScores.Text = "重設所有資料";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddRandom20
            // 
            this.btnAddRandom20.Location = new System.Drawing.Point(17, 396);
            this.btnAddRandom20.Name = "btnAddRandom20";
            this.btnAddRandom20.Size = new System.Drawing.Size(90, 28);
            this.btnAddRandom20.TabIndex = 16;
            this.btnAddRandom20.Text = "隨機加入20筆";
            this.btnAddRandom20.UseVisualStyleBackColor = true;
            this.btnAddRandom20.Click += new System.EventHandler(this.btnAddRandom20_Click);
            // 
            // Home_Work5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddRandom20);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.listViewResults2);
            this.Controls.Add(this.btnAddRandomData);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.textBoxChinese);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home_Work5";
            this.Text = "Home_Work5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxChinese;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.Button btnAddRandomData;
        private System.Windows.Forms.ListView listViewResults2;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnAddRandom20;
    }
}