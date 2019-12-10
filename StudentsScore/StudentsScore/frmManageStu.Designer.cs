namespace StudentsScore
{
    partial class frmManageStu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.cboSex);
            this.groupBox1.Controls.Add(this.txtSname);
            this.groupBox1.Controls.Add(this.txtSid);
            this.groupBox1.Controls.Add(this.lblClass);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblSname);
            this.groupBox1.Controls.Add(this.lblSid);
            this.groupBox1.Location = new System.Drawing.Point(49, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(364, 188);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(283, 188);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(202, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(302, 107);
            this.txtClass.MaxLength = 20;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 7;
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(111, 107);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(100, 20);
            this.cboSex.TabIndex = 6;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(302, 80);
            this.txtSname.MaxLength = 10;
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 5;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(111, 80);
            this.txtSid.MaxLength = 10;
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 4;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(255, 110);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(29, 12);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "班级";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(76, 110);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(255, 83);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(29, 12);
            this.lblSname.TabIndex = 1;
            this.lblSname.Text = "姓名";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(76, 83);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(29, 12);
            this.lblSid.TabIndex = 0;
            this.lblSid.Text = "学号";
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(49, 295);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(452, 150);
            this.dgvInfo.TabIndex = 11;
            // 
            // frmManageStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 480);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmManageStu";
            this.Text = "管理学生信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.DataGridView dgvInfo;
    }
}