namespace Nov5th
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OkBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.lblQuestion4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.rbtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.chkAnswer1 = new System.Windows.Forms.CheckBox();
            this.chkAnswer2 = new System.Windows.Forms.CheckBox();
            this.chkAnswer3 = new System.Windows.Forms.CheckBox();
            this.chkAnswer4 = new System.Windows.Forms.CheckBox();
            this.lstAnswer = new System.Windows.Forms.ListBox();
            this.cboAnswer = new System.Windows.Forms.ComboBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(99, 465);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "提交";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(345, 465);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "取消";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Location = new System.Drawing.Point(27, 29);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(131, 12);
            this.lblQuestion1.TabIndex = 6;
            this.lblQuestion1.Text = "1.对所学专业是否满意?";
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Location = new System.Drawing.Point(27, 104);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(131, 12);
            this.lblQuestion2.TabIndex = 7;
            this.lblQuestion2.Text = "2.目前的压力来自哪里?";
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.Location = new System.Drawing.Point(27, 188);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(155, 12);
            this.lblQuestion3.TabIndex = 8;
            this.lblQuestion3.Text = "3.目前最苦恼的事情是什么?";
            // 
            // lblQuestion4
            // 
            this.lblQuestion4.AutoSize = true;
            this.lblQuestion4.Location = new System.Drawing.Point(306, 188);
            this.lblQuestion4.Name = "lblQuestion4";
            this.lblQuestion4.Size = new System.Drawing.Size(191, 12);
            this.lblQuestion4.TabIndex = 9;
            this.lblQuestion4.Text = "4.你最需要学校提供哪方面的帮助?";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(27, 342);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 12);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "问卷结果:";
            // 
            // rbtnAnswer1
            // 
            this.rbtnAnswer1.AutoSize = true;
            this.rbtnAnswer1.Location = new System.Drawing.Point(29, 63);
            this.rbtnAnswer1.Name = "rbtnAnswer1";
            this.rbtnAnswer1.Size = new System.Drawing.Size(59, 16);
            this.rbtnAnswer1.TabIndex = 11;
            this.rbtnAnswer1.TabStop = true;
            this.rbtnAnswer1.Text = "很满意";
            this.rbtnAnswer1.UseVisualStyleBackColor = true;
            this.rbtnAnswer1.CheckedChanged += new System.EventHandler(this.rbtnAnswer_CheckedChanged);
            // 
            // rbtnAnswer2
            // 
            this.rbtnAnswer2.AutoSize = true;
            this.rbtnAnswer2.Location = new System.Drawing.Point(130, 63);
            this.rbtnAnswer2.Name = "rbtnAnswer2";
            this.rbtnAnswer2.Size = new System.Drawing.Size(71, 16);
            this.rbtnAnswer2.TabIndex = 12;
            this.rbtnAnswer2.TabStop = true;
            this.rbtnAnswer2.Text = "一般满意";
            this.rbtnAnswer2.UseVisualStyleBackColor = true;
            this.rbtnAnswer2.CheckedChanged += new System.EventHandler(this.rbtnAnswer_CheckedChanged);
            // 
            // rbtnAnswer3
            // 
            this.rbtnAnswer3.AutoSize = true;
            this.rbtnAnswer3.Location = new System.Drawing.Point(231, 63);
            this.rbtnAnswer3.Name = "rbtnAnswer3";
            this.rbtnAnswer3.Size = new System.Drawing.Size(59, 16);
            this.rbtnAnswer3.TabIndex = 13;
            this.rbtnAnswer3.TabStop = true;
            this.rbtnAnswer3.Text = "不满意";
            this.rbtnAnswer3.UseVisualStyleBackColor = true;
            this.rbtnAnswer3.CheckedChanged += new System.EventHandler(this.rbtnAnswer_CheckedChanged);
            // 
            // rbtnAnswer4
            // 
            this.rbtnAnswer4.AutoSize = true;
            this.rbtnAnswer4.Location = new System.Drawing.Point(332, 63);
            this.rbtnAnswer4.Name = "rbtnAnswer4";
            this.rbtnAnswer4.Size = new System.Drawing.Size(59, 16);
            this.rbtnAnswer4.TabIndex = 14;
            this.rbtnAnswer4.TabStop = true;
            this.rbtnAnswer4.Text = "不知道";
            this.rbtnAnswer4.UseVisualStyleBackColor = true;
            this.rbtnAnswer4.CheckedChanged += new System.EventHandler(this.rbtnAnswer_CheckedChanged);
            // 
            // chkAnswer1
            // 
            this.chkAnswer1.AutoSize = true;
            this.chkAnswer1.Location = new System.Drawing.Point(29, 138);
            this.chkAnswer1.Name = "chkAnswer1";
            this.chkAnswer1.Size = new System.Drawing.Size(60, 16);
            this.chkAnswer1.TabIndex = 15;
            this.chkAnswer1.Text = "专业课";
            this.chkAnswer1.UseVisualStyleBackColor = true;
            this.chkAnswer1.CheckedChanged += new System.EventHandler(this.chkAnswer_CheckedChanged);
            // 
            // chkAnswer2
            // 
            this.chkAnswer2.AutoSize = true;
            this.chkAnswer2.Location = new System.Drawing.Point(113, 138);
            this.chkAnswer2.Name = "chkAnswer2";
            this.chkAnswer2.Size = new System.Drawing.Size(60, 16);
            this.chkAnswer2.TabIndex = 16;
            this.chkAnswer2.Text = "公共课";
            this.chkAnswer2.UseVisualStyleBackColor = true;
            this.chkAnswer2.CheckedChanged += new System.EventHandler(this.chkAnswer_CheckedChanged);
            // 
            // chkAnswer3
            // 
            this.chkAnswer3.AutoSize = true;
            this.chkAnswer3.Location = new System.Drawing.Point(197, 138);
            this.chkAnswer3.Name = "chkAnswer3";
            this.chkAnswer3.Size = new System.Drawing.Size(48, 16);
            this.chkAnswer3.TabIndex = 17;
            this.chkAnswer3.Text = "生活";
            this.chkAnswer3.UseVisualStyleBackColor = true;
            this.chkAnswer3.CheckedChanged += new System.EventHandler(this.chkAnswer_CheckedChanged);
            // 
            // chkAnswer4
            // 
            this.chkAnswer4.AutoSize = true;
            this.chkAnswer4.Location = new System.Drawing.Point(281, 138);
            this.chkAnswer4.Name = "chkAnswer4";
            this.chkAnswer4.Size = new System.Drawing.Size(48, 16);
            this.chkAnswer4.TabIndex = 18;
            this.chkAnswer4.Text = "其他";
            this.chkAnswer4.UseVisualStyleBackColor = true;
            this.chkAnswer4.CheckedChanged += new System.EventHandler(this.chkAnswer_CheckedChanged);
            // 
            // lstAnswer
            // 
            this.lstAnswer.FormattingEnabled = true;
            this.lstAnswer.ItemHeight = 12;
            this.lstAnswer.Location = new System.Drawing.Point(29, 215);
            this.lstAnswer.Name = "lstAnswer";
            this.lstAnswer.Size = new System.Drawing.Size(170, 112);
            this.lstAnswer.TabIndex = 19;
            // 
            // cboAnswer
            // 
            this.cboAnswer.FormattingEnabled = true;
            this.cboAnswer.Location = new System.Drawing.Point(308, 215);
            this.cboAnswer.Name = "cboAnswer";
            this.cboAnswer.Size = new System.Drawing.Size(137, 20);
            this.cboAnswer.TabIndex = 20;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 12;
            this.lstResult.Location = new System.Drawing.Point(29, 362);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(416, 76);
            this.lstResult.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 513);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.cboAnswer);
            this.Controls.Add(this.lstAnswer);
            this.Controls.Add(this.chkAnswer4);
            this.Controls.Add(this.chkAnswer3);
            this.Controls.Add(this.chkAnswer2);
            this.Controls.Add(this.chkAnswer1);
            this.Controls.Add(this.rbtnAnswer4);
            this.Controls.Add(this.rbtnAnswer3);
            this.Controls.Add(this.rbtnAnswer2);
            this.Controls.Add(this.rbtnAnswer1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblQuestion4);
            this.Controls.Add(this.lblQuestion3);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "Form1";
            this.Text = "学生问卷调查";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.Label lblQuestion4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rbtnAnswer1;
        private System.Windows.Forms.RadioButton rbtnAnswer2;
        private System.Windows.Forms.RadioButton rbtnAnswer3;
        private System.Windows.Forms.RadioButton rbtnAnswer4;
        private System.Windows.Forms.CheckBox chkAnswer1;
        private System.Windows.Forms.CheckBox chkAnswer2;
        private System.Windows.Forms.CheckBox chkAnswer3;
        private System.Windows.Forms.CheckBox chkAnswer4;
        private System.Windows.Forms.ListBox lstAnswer;
        private System.Windows.Forms.ComboBox cboAnswer;
        private System.Windows.Forms.ListBox lstResult;
    }
}

