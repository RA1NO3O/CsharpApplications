namespace StudentsScore
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCourseSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCourseAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCourseUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCourseDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScoreSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScoreAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScoreUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScoreDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCourse = new System.Windows.Forms.ToolStripButton();
            this.tsbtnScore = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStudent,
            this.tsmiCourse,
            this.tsmiScore,
            this.tsmiAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiStudent
            // 
            this.tsmiStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStudentSearch,
            this.tsmiStudentAdd,
            this.tsmiStudentUpdate,
            this.tsmiStudentDelete});
            this.tsmiStudent.Name = "tsmiStudent";
            this.tsmiStudent.Size = new System.Drawing.Size(107, 21);
            this.tsmiStudent.Text = "学生信息管理(&T)";
            // 
            // tsmiStudentSearch
            // 
            this.tsmiStudentSearch.Name = "tsmiStudentSearch";
            this.tsmiStudentSearch.Size = new System.Drawing.Size(180, 22);
            this.tsmiStudentSearch.Text = "学生信息查询";
            this.tsmiStudentSearch.Click += new System.EventHandler(this.tsmiStudentSearch_Click);
            // 
            // tsmiStudentAdd
            // 
            this.tsmiStudentAdd.Name = "tsmiStudentAdd";
            this.tsmiStudentAdd.Size = new System.Drawing.Size(180, 22);
            this.tsmiStudentAdd.Text = "学生信息添加";
            this.tsmiStudentAdd.Click += new System.EventHandler(this.tsmiStudentAdd_Click);
            // 
            // tsmiStudentUpdate
            // 
            this.tsmiStudentUpdate.Name = "tsmiStudentUpdate";
            this.tsmiStudentUpdate.Size = new System.Drawing.Size(180, 22);
            this.tsmiStudentUpdate.Text = "学生信息修改";
            this.tsmiStudentUpdate.Click += new System.EventHandler(this.tsmiStudentUpdate_Click);
            // 
            // tsmiStudentDelete
            // 
            this.tsmiStudentDelete.Name = "tsmiStudentDelete";
            this.tsmiStudentDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmiStudentDelete.Text = "学生信息删除";
            this.tsmiStudentDelete.Click += new System.EventHandler(this.tsmiStudentDelete_Click);
            // 
            // tsmiCourse
            // 
            this.tsmiCourse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCourseSearch,
            this.tsmiCourseAdd,
            this.tsmiCourseUpdate,
            this.tsmiCourseDelete});
            this.tsmiCourse.Name = "tsmiCourse";
            this.tsmiCourse.Size = new System.Drawing.Size(124, 21);
            this.tsmiCourse.Text = "课程信息管理（&C）";
            // 
            // tsmiCourseSearch
            // 
            this.tsmiCourseSearch.Name = "tsmiCourseSearch";
            this.tsmiCourseSearch.Size = new System.Drawing.Size(180, 22);
            this.tsmiCourseSearch.Text = "课程信息查询";
            this.tsmiCourseSearch.Click += new System.EventHandler(this.tsmiCourseSearch_Click);
            // 
            // tsmiCourseAdd
            // 
            this.tsmiCourseAdd.Name = "tsmiCourseAdd";
            this.tsmiCourseAdd.Size = new System.Drawing.Size(180, 22);
            this.tsmiCourseAdd.Text = "课程信息添加";
            this.tsmiCourseAdd.Click += new System.EventHandler(this.tsmiCourseAdd_Click);
            // 
            // tsmiCourseUpdate
            // 
            this.tsmiCourseUpdate.Name = "tsmiCourseUpdate";
            this.tsmiCourseUpdate.Size = new System.Drawing.Size(180, 22);
            this.tsmiCourseUpdate.Text = "课程信息修改";
            this.tsmiCourseUpdate.Click += new System.EventHandler(this.tsmiCourseUpdate_Click);
            // 
            // tsmiCourseDelete
            // 
            this.tsmiCourseDelete.Name = "tsmiCourseDelete";
            this.tsmiCourseDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmiCourseDelete.Text = "课程信息删除";
            this.tsmiCourseDelete.Click += new System.EventHandler(this.tsmiCourseDelete_Click);
            // 
            // tsmiScore
            // 
            this.tsmiScore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScoreSearch,
            this.tsmiScoreAdd,
            this.tsmiScoreUpdate,
            this.tsmiScoreDelete});
            this.tsmiScore.Name = "tsmiScore";
            this.tsmiScore.Size = new System.Drawing.Size(84, 21);
            this.tsmiScore.Text = "成绩管理(&R)";
            // 
            // tsmiScoreSearch
            // 
            this.tsmiScoreSearch.Name = "tsmiScoreSearch";
            this.tsmiScoreSearch.Size = new System.Drawing.Size(180, 22);
            this.tsmiScoreSearch.Text = "成绩查询";
            this.tsmiScoreSearch.Click += new System.EventHandler(this.tsmiScoreSearch_Click);
            // 
            // tsmiScoreAdd
            // 
            this.tsmiScoreAdd.Name = "tsmiScoreAdd";
            this.tsmiScoreAdd.Size = new System.Drawing.Size(180, 22);
            this.tsmiScoreAdd.Text = "成绩添加";
            this.tsmiScoreAdd.Click += new System.EventHandler(this.tsmiScoreAdd_Click);
            // 
            // tsmiScoreUpdate
            // 
            this.tsmiScoreUpdate.Name = "tsmiScoreUpdate";
            this.tsmiScoreUpdate.Size = new System.Drawing.Size(180, 22);
            this.tsmiScoreUpdate.Text = "成绩修改";
            this.tsmiScoreUpdate.Click += new System.EventHandler(this.tsmiScoreUpdate_Click);
            // 
            // tsmiScoreDelete
            // 
            this.tsmiScoreDelete.Name = "tsmiScoreDelete";
            this.tsmiScoreDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmiScoreDelete.Text = "成绩删除";
            this.tsmiScoreDelete.Click += new System.EventHandler(this.tsmiScoreDelete_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVersion});
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(60, 21);
            this.tsmiAbout.Text = "关于(&A)";
            // 
            // tsmiVersion
            // 
            this.tsmiVersion.Name = "tsmiVersion";
            this.tsmiVersion.Size = new System.Drawing.Size(180, 22);
            this.tsmiVersion.Text = "版本";
            this.tsmiVersion.Click += new System.EventHandler(this.tsmiVersion_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblInfo
            // 
            this.tsslblInfo.Name = "tsslblInfo";
            this.tsslblInfo.Size = new System.Drawing.Size(152, 17);
            this.tsslblInfo.Text = "欢迎进入学生成绩管理系统";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStudent,
            this.tsbtnCourse,
            this.tsbtnScore});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnStudent
            // 
            this.tsbtnStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStudent.Image = global::StudentsScore.Properties.Resources.student;
            this.tsbtnStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStudent.Name = "tsbtnStudent";
            this.tsbtnStudent.Size = new System.Drawing.Size(23, 22);
            this.tsbtnStudent.Text = "学生信息查询";
            this.tsbtnStudent.Click += new System.EventHandler(this.tsbtnStudent_Click);
            // 
            // tsbtnCourse
            // 
            this.tsbtnCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCourse.Image = global::StudentsScore.Properties.Resources.course;
            this.tsbtnCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCourse.Name = "tsbtnCourse";
            this.tsbtnCourse.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCourse.Text = "课程信息查询";
            this.tsbtnCourse.Click += new System.EventHandler(this.tsbtnCourse_Click);
            // 
            // tsbtnScore
            // 
            this.tsbtnScore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnScore.Image = global::StudentsScore.Properties.Resources.score;
            this.tsbtnScore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnScore.Name = "tsbtnScore";
            this.tsbtnScore.Size = new System.Drawing.Size(23, 22);
            this.tsbtnScore.Text = "成绩查询";
            this.tsbtnScore.Click += new System.EventHandler(this.tsbtnScore_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiCourse;
        private System.Windows.Forms.ToolStripMenuItem tsmiScore;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnStudent;
        private System.Windows.Forms.ToolStripButton tsbtnCourse;
        private System.Windows.Forms.ToolStripButton tsbtnScore;
        private System.Windows.Forms.ToolStripStatusLabel tsslblInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiCourseSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiCourseAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiCourseUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiCourseDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiScoreSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiScoreAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiScoreUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiScoreDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiVersion;
    }
}