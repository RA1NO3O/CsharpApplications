namespace HumanResourseSystem
{
    partial class QuickAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.ms_QuickAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加人员档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加工资记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_QuickAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::HumanResourseSystem.Properties.Resources.add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ms_QuickAdd
            // 
            this.ms_QuickAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加人员档案ToolStripMenuItem,
            this.添加工资记录ToolStripMenuItem});
            this.ms_QuickAdd.Name = "ms_QuickAdd";
            this.ms_QuickAdd.Size = new System.Drawing.Size(193, 70);
            // 
            // 添加人员档案ToolStripMenuItem
            // 
            this.添加人员档案ToolStripMenuItem.Image = global::HumanResourseSystem.Properties.Resources.student;
            this.添加人员档案ToolStripMenuItem.Name = "添加人员档案ToolStripMenuItem";
            this.添加人员档案ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.添加人员档案ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.添加人员档案ToolStripMenuItem.Text = "添加人员记录";
            this.添加人员档案ToolStripMenuItem.Click += new System.EventHandler(this.添加人员档案ToolStripMenuItem_Click);
            // 
            // 添加工资记录ToolStripMenuItem
            // 
            this.添加工资记录ToolStripMenuItem.Image = global::HumanResourseSystem.Properties.Resources.score;
            this.添加工资记录ToolStripMenuItem.Name = "添加工资记录ToolStripMenuItem";
            this.添加工资记录ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.添加工资记录ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.添加工资记录ToolStripMenuItem.Text = "添加工资记录";
            this.添加工资记录ToolStripMenuItem.Click += new System.EventHandler(this.添加工资记录ToolStripMenuItem_Click);
            // 
            // QuickAdd
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(53, 55);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuickAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ms_QuickAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip ms_QuickAdd;
        private System.Windows.Forms.ToolStripMenuItem 添加人员档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加工资记录ToolStripMenuItem;
    }
}