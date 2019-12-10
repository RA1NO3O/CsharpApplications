namespace StudentsScore
{
    partial class frmAddStu
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
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.gbxStudent = new System.Windows.Forms.GroupBox();
            this.gbxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(101, 59);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(100, 20);
            this.cboSex.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(112, 112);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 21);
            this.txtAddress.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(277, 85);
            this.txtTel.MaxLength = 30;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 21);
            this.txtTel.TabIndex = 11;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(101, 85);
            this.txtClass.MaxLength = 20;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 10;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(277, 59);
            this.txtBirthday.MaxLength = 20;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(100, 21);
            this.txtBirthday.TabIndex = 9;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(277, 32);
            this.txtSname.MaxLength = 10;
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 8;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(101, 32);
            this.txtSid.MaxLength = 10;
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(53, 115);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 12);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "家庭地址";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(230, 88);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(29, 12);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "电话";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(230, 62);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(29, 12);
            this.lblBirthday.TabIndex = 3;
            this.lblBirthday.Text = "生日";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(54, 62);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(230, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(54, 35);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(29, 12);
            this.lblSid.TabIndex = 0;
            this.lblSid.Text = "学号";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(166, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(54, 88);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(29, 12);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "班级";
            // 
            // gbxStudent
            // 
            this.gbxStudent.Controls.Add(this.cboSex);
            this.gbxStudent.Controls.Add(this.txtAddress);
            this.gbxStudent.Controls.Add(this.txtTel);
            this.gbxStudent.Controls.Add(this.txtClass);
            this.gbxStudent.Controls.Add(this.txtBirthday);
            this.gbxStudent.Controls.Add(this.txtSname);
            this.gbxStudent.Controls.Add(this.txtSid);
            this.gbxStudent.Controls.Add(this.lblAddress);
            this.gbxStudent.Controls.Add(this.lblTel);
            this.gbxStudent.Controls.Add(this.lblClass);
            this.gbxStudent.Controls.Add(this.lblBirthday);
            this.gbxStudent.Controls.Add(this.lblSex);
            this.gbxStudent.Controls.Add(this.lblName);
            this.gbxStudent.Controls.Add(this.lblSid);
            this.gbxStudent.Location = new System.Drawing.Point(66, 85);
            this.gbxStudent.Name = "gbxStudent";
            this.gbxStudent.Size = new System.Drawing.Size(426, 167);
            this.gbxStudent.TabIndex = 4;
            this.gbxStudent.TabStop = false;
            this.gbxStudent.Text = "学生信息";
            // 
            // frmAddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 384);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxStudent);
            this.Name = "frmAddStu";
            this.Text = "添加学生信息";
            this.gbxStudent.ResumeLayout(false);
            this.gbxStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.GroupBox gbxStudent;
    }
}