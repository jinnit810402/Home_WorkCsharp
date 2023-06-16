namespace Home_Work2
{
    partial class Home_Work8
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btntimes = new System.Windows.Forms.Button();
            this.btnDivided_By = new System.Windows.Forms.Button();
            this.labAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(91, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(91, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(91, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(91, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "==============";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(168, 87);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(101, 32);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.Location = new System.Drawing.Point(168, 125);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(101, 32);
            this.txtNum2.TabIndex = 5;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(284, 69);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(64, 30);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(284, 105);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(64, 30);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btntimes
            // 
            this.btntimes.Location = new System.Drawing.Point(284, 141);
            this.btntimes.Name = "btntimes";
            this.btntimes.Size = new System.Drawing.Size(64, 30);
            this.btntimes.TabIndex = 9;
            this.btntimes.Text = "*";
            this.btntimes.UseVisualStyleBackColor = true;
            this.btntimes.Click += new System.EventHandler(this.Btntimes_Click);
            // 
            // btnDivided_By
            // 
            this.btnDivided_By.Location = new System.Drawing.Point(284, 177);
            this.btnDivided_By.Name = "btnDivided_By";
            this.btnDivided_By.Size = new System.Drawing.Size(64, 30);
            this.btnDivided_By.TabIndex = 10;
            this.btnDivided_By.Text = "/";
            this.btnDivided_By.UseVisualStyleBackColor = true;
            this.btnDivided_By.Click += new System.EventHandler(this.BtnDivided_By_Click);
            // 
            // labAnswer
            // 
            this.labAnswer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAnswer.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.Location = new System.Drawing.Point(168, 183);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(100, 24);
            this.labAnswer.TabIndex = 11;
            // 
            // Home_Work8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 230);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.btnDivided_By);
            this.Controls.Add(this.btntimes);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home_Work8";
            this.Text = "Home_Work8";
            this.Load += new System.EventHandler(this.Home_Work8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btntimes;
        private System.Windows.Forms.Button btnDivided_By;
        private System.Windows.Forms.Label labAnswer;
    }
}