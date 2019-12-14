namespace StudentsScore
{
    partial class frmEditCourse
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
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.txtCname);
            this.gbxCourse.Controls.Add(this.txtCredit);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.lblCname);
            this.gbxCourse.Controls.Add(this.lblCredit);
            this.gbxCourse.Controls.Add(this.lblCid);
            this.gbxCourse.Location = new System.Drawing.Point(12, 25);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(493, 161);
            this.gbxCourse.TabIndex = 3;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "课程信息";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(133, 115);
            this.txtCname.MaxLength = 30;
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(263, 21);
            this.txtCname.TabIndex = 5;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(296, 62);
            this.txtCredit.MaxLength = 10;
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(100, 21);
            this.txtCredit.TabIndex = 4;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(133, 62);
            this.txtCid.MaxLength = 10;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 3;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Location = new System.Drawing.Point(74, 118);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(53, 12);
            this.lblCname.TabIndex = 2;
            this.lblCname.Text = "课程名称";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(249, 65);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(29, 12);
            this.lblCredit.TabIndex = 1;
            this.lblCredit.Text = "学分";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(74, 65);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(53, 12);
            this.lblCid.TabIndex = 0;
            this.lblCid.Text = "课程编号";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(145, 223);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 271);
            this.Controls.Add(this.gbxCourse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Name = "frmEditCourse";
            this.Text = "修改课程信息";
            this.Load += new System.EventHandler(this.frmEditCourse_Load);
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
    }
}