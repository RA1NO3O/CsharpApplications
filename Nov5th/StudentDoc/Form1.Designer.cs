namespace StudentDoc
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
            this.tctlStudent = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtBirthplace = new System.Windows.Forms.TextBox();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBirthplace = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblRewards = new System.Windows.Forms.Label();
            this.lblPunishment = new System.Windows.Forms.Label();
            this.txtRewards = new System.Windows.Forms.TextBox();
            this.txtPunishment = new System.Windows.Forms.TextBox();
            this.tctlStudent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctlStudent
            // 
            this.tctlStudent.Controls.Add(this.tabPage1);
            this.tctlStudent.Controls.Add(this.tabPage2);
            this.tctlStudent.Location = new System.Drawing.Point(38, 61);
            this.tctlStudent.Name = "tctlStudent";
            this.tctlStudent.SelectedIndex = 0;
            this.tctlStudent.Size = new System.Drawing.Size(421, 341);
            this.tctlStudent.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cboSex);
            this.tabPage1.Controls.Add(this.txtBirthplace);
            this.tabPage1.Controls.Add(this.txtNation);
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.lblBirthplace);
            this.tabPage1.Controls.Add(this.lblNation);
            this.tabPage1.Controls.Add(this.lblAge);
            this.tabPage1.Controls.Add(this.lblSex);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.lblID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本情况";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGrade);
            this.groupBox1.Controls.Add(this.lblClass);
            this.groupBox1.Controls.Add(this.lblMajor);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.txtMajor);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.cboDepartment);
            this.groupBox1.Location = new System.Drawing.Point(21, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 138);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所属";
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(85, 63);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(121, 20);
            this.cboSex.TabIndex = 11;
            // 
            // txtBirthplace
            // 
            this.txtBirthplace.Location = new System.Drawing.Point(271, 95);
            this.txtBirthplace.Name = "txtBirthplace";
            this.txtBirthplace.Size = new System.Drawing.Size(100, 21);
            this.txtBirthplace.TabIndex = 10;
            // 
            // txtNation
            // 
            this.txtNation.Location = new System.Drawing.Point(85, 95);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(121, 21);
            this.txtNation.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(271, 62);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 21);
            this.txtAge.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(271, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(85, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 21);
            this.txtID.TabIndex = 6;
            // 
            // lblBirthplace
            // 
            this.lblBirthplace.AutoSize = true;
            this.lblBirthplace.Location = new System.Drawing.Point(224, 98);
            this.lblBirthplace.Name = "lblBirthplace";
            this.lblBirthplace.Size = new System.Drawing.Size(35, 12);
            this.lblBirthplace.TabIndex = 5;
            this.lblBirthplace.Text = "籍贯:";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Location = new System.Drawing.Point(38, 98);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(35, 12);
            this.lblNation.TabIndex = 4;
            this.lblNation.Text = "民族:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(224, 66);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 12);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "年龄:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(38, 66);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(35, 12);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(224, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(38, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 12);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "学号:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPunishment);
            this.tabPage2.Controls.Add(this.txtRewards);
            this.tabPage2.Controls.Add(this.lblPunishment);
            this.tabPage2.Controls.Add(this.lblRewards);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "奖惩信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(167, 432);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(268, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Items.AddRange(new object[] {
            "工学院",
            "理学院",
            "商学院",
            "法学院",
            "艺术学院",
            "外语学院"});
            this.cboDepartment.Location = new System.Drawing.Point(79, 45);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(100, 20);
            this.cboDepartment.TabIndex = 0;
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboGrade.Location = new System.Drawing.Point(238, 80);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(100, 20);
            this.cboGrade.TabIndex = 1;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(238, 45);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 21);
            this.txtMajor.TabIndex = 2;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(79, 80);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 3;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(32, 48);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(35, 12);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "院系:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(191, 48);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(35, 12);
            this.lblMajor.TabIndex = 5;
            this.lblMajor.Text = "专业:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(32, 83);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 12);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "班级:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(191, 83);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(35, 12);
            this.lblGrade.TabIndex = 7;
            this.lblGrade.Text = "年级:";
            // 
            // lblRewards
            // 
            this.lblRewards.AutoSize = true;
            this.lblRewards.Location = new System.Drawing.Point(34, 43);
            this.lblRewards.Name = "lblRewards";
            this.lblRewards.Size = new System.Drawing.Size(149, 12);
            this.lblRewards.TabIndex = 0;
            this.lblRewards.Text = "1.何时何地获得过何种奖励";
            // 
            // lblPunishment
            // 
            this.lblPunishment.AutoSize = true;
            this.lblPunishment.Location = new System.Drawing.Point(34, 172);
            this.lblPunishment.Name = "lblPunishment";
            this.lblPunishment.Size = new System.Drawing.Size(137, 12);
            this.lblPunishment.TabIndex = 1;
            this.lblPunishment.Text = "2.何时何地受过何种处分";
            // 
            // txtRewards
            // 
            this.txtRewards.Location = new System.Drawing.Point(36, 58);
            this.txtRewards.Multiline = true;
            this.txtRewards.Name = "txtRewards";
            this.txtRewards.Size = new System.Drawing.Size(339, 88);
            this.txtRewards.TabIndex = 2;
            // 
            // txtPunishment
            // 
            this.txtPunishment.Location = new System.Drawing.Point(36, 187);
            this.txtPunishment.Multiline = true;
            this.txtPunishment.Name = "txtPunishment";
            this.txtPunishment.Size = new System.Drawing.Size(339, 93);
            this.txtPunishment.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 484);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tctlStudent);
            this.Name = "Form1";
            this.Text = "学生档案";
            this.tctlStudent.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctlStudent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtBirthplace;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblBirthplace;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPunishment;
        private System.Windows.Forms.TextBox txtRewards;
        private System.Windows.Forms.Label lblPunishment;
        private System.Windows.Forms.Label lblRewards;
    }
}

