namespace StuTestArrangR
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
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("大学英语");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("高等数学");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("信息技术");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("一年级", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("数据库技术与应用");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("C#程序设计");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("二年级", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34});
            this.tvwCourse = new System.Windows.Forms.TreeView();
            this.lvwInformation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tvwCourse
            // 
            this.tvwCourse.Location = new System.Drawing.Point(12, 25);
            this.tvwCourse.Name = "tvwCourse";
            treeNode29.Name = "节点5";
            treeNode29.Text = "大学英语";
            treeNode30.Name = "节点7";
            treeNode30.Text = "高等数学";
            treeNode31.Name = "节点8";
            treeNode31.Text = "信息技术";
            treeNode32.Name = "节点0";
            treeNode32.Text = "一年级";
            treeNode33.Name = "节点9";
            treeNode33.Text = "数据库技术与应用";
            treeNode34.Name = "节点10";
            treeNode34.Text = "C#程序设计";
            treeNode35.Name = "节点4";
            treeNode35.Text = "二年级";
            this.tvwCourse.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode35});
            this.tvwCourse.Size = new System.Drawing.Size(166, 194);
            this.tvwCourse.TabIndex = 0;
            this.tvwCourse.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCourse_AfterSelect);
            // 
            // lvwInformation
            // 
            this.lvwInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwInformation.HideSelection = false;
            this.lvwInformation.Location = new System.Drawing.Point(184, 25);
            this.lvwInformation.Name = "lvwInformation";
            this.lvwInformation.Size = new System.Drawing.Size(398, 194);
            this.lvwInformation.TabIndex = 1;
            this.lvwInformation.UseCompatibleStateImageBehavior = false;
            this.lvwInformation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "考试科目";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "考试时间";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "考试地点";
            this.columnHeader3.Width = 165;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 231);
            this.Controls.Add(this.lvwInformation);
            this.Controls.Add(this.tvwCourse);
            this.Name = "Form1";
            this.Text = "学生考试安排";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwCourse;
        private System.Windows.Forms.ListView lvwInformation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

