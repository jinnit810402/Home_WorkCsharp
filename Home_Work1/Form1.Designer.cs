namespace Home_Work1
{
    partial class Form1
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
            this.labName1 = new System.Windows.Forms.Label();
            this.labName2 = new System.Windows.Forms.Label();
            this.labName3 = new System.Windows.Forms.Label();
            this.labName4 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName1
            // 
            this.labName1.AutoSize = true;
            this.labName1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labName1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labName1.Location = new System.Drawing.Point(29, 187);
            this.labName1.Name = "labName1";
            this.labName1.Size = new System.Drawing.Size(67, 24);
            this.labName1.TabIndex = 0;
            this.labName1.Text = "姓名:";
            this.labName1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labName2
            // 
            this.labName2.AutoSize = true;
            this.labName2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labName2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labName2.Location = new System.Drawing.Point(29, 248);
            this.labName2.Name = "labName2";
            this.labName2.Size = new System.Drawing.Size(157, 24);
            this.labName2.TabIndex = 1;
            this.labName2.Text = "English Name:";
            this.labName2.Click += new System.EventHandler(this.labName2_Click);
            // 
            // labName3
            // 
            this.labName3.AutoSize = true;
            this.labName3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labName3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labName3.Location = new System.Drawing.Point(29, 304);
            this.labName3.Name = "labName3";
            this.labName3.Size = new System.Drawing.Size(67, 24);
            this.labName3.TabIndex = 2;
            this.labName3.Text = "性別:";
            this.labName3.Click += new System.EventHandler(this.labName3_Click);
            // 
            // labName4
            // 
            this.labName4.AutoSize = true;
            this.labName4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labName4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labName4.Location = new System.Drawing.Point(29, 360);
            this.labName4.Name = "labName4";
            this.labName4.Size = new System.Drawing.Size(67, 24);
            this.labName4.TabIndex = 3;
            this.labName4.Text = "星座:";
            this.labName4.Click += new System.EventHandler(this.labName4_Click);
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName1.Location = new System.Drawing.Point(182, 187);
            this.txtName1.Multiline = true;
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(190, 33);
            this.txtName1.TabIndex = 4;
            this.txtName1.TextChanged += new System.EventHandler(this.txtName1_TextChanged);
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName2.Location = new System.Drawing.Point(182, 239);
            this.txtName2.Multiline = true;
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(190, 33);
            this.txtName2.TabIndex = 5;
            this.txtName2.TextChanged += new System.EventHandler(this.txtName2_TextChanged);
            // 
            // txtName3
            // 
            this.txtName3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName3.Location = new System.Drawing.Point(182, 292);
            this.txtName3.Multiline = true;
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(190, 33);
            this.txtName3.TabIndex = 6;
            this.txtName3.TextChanged += new System.EventHandler(this.txtName3_TextChanged);
            // 
            // txtName4
            // 
            this.txtName4.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName4.Location = new System.Drawing.Point(182, 348);
            this.txtName4.Multiline = true;
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(190, 33);
            this.txtName4.TabIndex = 7;
            this.txtName4.TextChanged += new System.EventHandler(this.txtName4_TextChanged);
            // 
            // btnSayHi
            // 
            this.btnSayHi.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Location = new System.Drawing.Point(182, 403);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(91, 35);
            this.btnSayHi.TabIndex = 9;
            this.btnSayHi.Text = "Say Hi!";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // btnSayHello
            // 
            this.btnSayHello.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Location = new System.Drawing.Point(33, 403);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(87, 35);
            this.btnSayHello.TabIndex = 8;
            this.btnSayHello.Text = "Say Hello!";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnsayhello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.txtName4);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.labName4);
            this.Controls.Add(this.labName3);
            this.Controls.Add(this.labName2);
            this.Controls.Add(this.labName1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName1;
        private System.Windows.Forms.Label labName2;
        private System.Windows.Forms.Label labName3;
        private System.Windows.Forms.Label labName4;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Button btnSayHello;
    }
}

