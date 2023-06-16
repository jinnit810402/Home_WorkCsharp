namespace Home_Work2
{
    partial class Home_work2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.loanTermTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.downPaymentTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "頭期款";
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(211, 110);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.loanAmountTextBox.TabIndex = 4;
            // 
            // loanTermTextBox
            // 
            this.loanTermTextBox.Location = new System.Drawing.Point(211, 141);
            this.loanTermTextBox.Name = "loanTermTextBox";
            this.loanTermTextBox.Size = new System.Drawing.Size(100, 22);
            this.loanTermTextBox.TabIndex = 5;
            this.loanTermTextBox.TextChanged += new System.EventHandler(this.loanTermTextBox_TextChanged);
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(211, 203);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(100, 22);
            this.interestRateTextBox.TabIndex = 6;
            // 
            // downPaymentTextBox
            // 
            this.downPaymentTextBox.Location = new System.Drawing.Point(211, 239);
            this.downPaymentTextBox.Name = "downPaymentTextBox";
            this.downPaymentTextBox.Size = new System.Drawing.Size(100, 22);
            this.downPaymentTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(75, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "PMT(月付";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(262, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "總付款";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(409, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Report_Click);
            // 
            // Home_work2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downPaymentTextBox);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.loanTermTextBox);
            this.Controls.Add(this.loanAmountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home_work2";
            this.Text = "貸款金額計算";
            this.Load += new System.EventHandler(this.Home_work2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.TextBox loanTermTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox downPaymentTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

