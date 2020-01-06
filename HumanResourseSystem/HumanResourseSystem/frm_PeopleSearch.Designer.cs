﻿namespace HumanResourseSystem
{
    partial class frm_PeopleSearch
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_LIKEMODE = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Sex = new System.Windows.Forms.ComboBox();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.txt_Birthday = new System.Windows.Forms.TextBox();
            this.txt_Inworkdate = new System.Windows.Forms.TextBox();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_LIKEMODE);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通常";
            // 
            // chk_LIKEMODE
            // 
            this.chk_LIKEMODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_LIKEMODE.AutoSize = true;
            this.chk_LIKEMODE.Location = new System.Drawing.Point(20, 207);
            this.chk_LIKEMODE.Name = "chk_LIKEMODE";
            this.chk_LIKEMODE.Size = new System.Drawing.Size(90, 16);
            this.chk_LIKEMODE.TabIndex = 6;
            this.chk_LIKEMODE.Text = "包含模式(&L)";
            this.toolTip1.SetToolTip(this.chk_LIKEMODE, "包含模式是一种模糊查询模式,它会将所有符合包含给定值的字段筛选出来\r\n(暂不支持范围模糊查询).");
            this.chk_LIKEMODE.UseVisualStyleBackColor = true;
            this.chk_LIKEMODE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.55224F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.44776F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.Controls.Add(this.txt_Address, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Phone, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Age, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Sex, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Position, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Birthday, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Inworkdate, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 133);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(72, 108);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(158, 21);
            this.txt_Address.TabIndex = 35;
            this.txt_Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "编号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 28);
            this.label9.TabIndex = 26;
            this.label9.Text = "住址";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(313, 82);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(200, 21);
            this.txt_Phone.TabIndex = 34;
            this.txt_Phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(72, 3);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(158, 21);
            this.txt_ID.TabIndex = 27;
            this.txt_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "电话";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "姓名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(313, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(200, 21);
            this.txt_Name.TabIndex = 28;
            this.txt_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "就职岗位";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "性别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(313, 28);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(200, 21);
            this.txt_Age.TabIndex = 30;
            this.txt_Age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "入职日期";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "年龄";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "出生日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Sex
            // 
            this.txt_Sex.FormattingEnabled = true;
            this.txt_Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.txt_Sex.Location = new System.Drawing.Point(72, 28);
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.Size = new System.Drawing.Size(158, 20);
            this.txt_Sex.TabIndex = 29;
            this.txt_Sex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // txt_Position
            // 
            this.txt_Position.Location = new System.Drawing.Point(72, 82);
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.Size = new System.Drawing.Size(158, 21);
            this.txt_Position.TabIndex = 33;
            this.txt_Position.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // txt_Birthday
            // 
            this.txt_Birthday.Location = new System.Drawing.Point(72, 55);
            this.txt_Birthday.Name = "txt_Birthday";
            this.txt_Birthday.Size = new System.Drawing.Size(158, 21);
            this.txt_Birthday.TabIndex = 31;
            this.txt_Birthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // txt_Inworkdate
            // 
            this.txt_Inworkdate.Location = new System.Drawing.Point(313, 55);
            this.txt_Inworkdate.Name = "txt_Inworkdate";
            this.txt_Inworkdate.Size = new System.Drawing.Size(200, 21);
            this.txt_Inworkdate.TabIndex = 32;
            this.txt_Inworkdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // btn_Execute
            // 
            this.btn_Execute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Execute.Location = new System.Drawing.Point(217, 256);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(133, 34);
            this.btn_Execute.TabIndex = 3;
            this.btn_Execute.Text = "执行(&E)";
            this.toolTip1.SetToolTip(this.btn_Execute, "按照指定的条件执行查询并返回结果.");
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            this.btn_Execute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.Location = new System.Drawing.Point(380, 256);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(133, 34);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "重置(&R)";
            this.toolTip1.SetToolTip(this.btn_Reset, "清空所有文本框.");
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            this.btn_Reset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            // 
            // frm_PeopleSearch
            // 
            this.AcceptButton = this.btn_Execute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 302);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PeopleSearch";
            this.Text = "查找人员..";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PeopleSearch_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_Sex;
        private System.Windows.Forms.TextBox txt_Position;
        private System.Windows.Forms.TextBox txt_Birthday;
        private System.Windows.Forms.TextBox txt_Inworkdate;
        private System.Windows.Forms.CheckBox chk_LIKEMODE;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}