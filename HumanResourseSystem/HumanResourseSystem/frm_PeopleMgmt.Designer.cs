namespace HumanResourseSystem
{
    partial class frm_PeopleMgmt
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            frm_PeopleMgmt.hintBox = new System.Windows.Forms.ToolStripStatusLabel();
            frm_PeopleMgmt.dgv_People = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(frm_PeopleMgmt.dgv_People)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Search.Location = new System.Drawing.Point(12, 354);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "查找(&S)";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseEnter += new System.EventHandler(this.btn_Search_MouseEnter);
            this.btn_Search.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.Green;
            this.btn_Add.Location = new System.Drawing.Point(436, 354);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "添加(&A)";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.MouseEnter += new System.EventHandler(this.btn_Add_MouseEnter);
            this.btn_Add.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BackColor = System.Drawing.Color.Teal;
            this.btn_Edit.Location = new System.Drawing.Point(517, 354);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "修改(&E)";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            this.btn_Edit.MouseEnter += new System.EventHandler(this.btn_Add_MouseEnter);
            this.btn_Edit.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.Location = new System.Drawing.Point(598, 354);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "删除(&D)";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.MouseEnter += new System.EventHandler(this.btn_Add_MouseEnter);
            this.btn_Delete.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.Location = new System.Drawing.Point(93, 354);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(109, 23);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "重置/刷新(&R)";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            this.btn_Reset.MouseEnter += new System.EventHandler(this.btn_Reset_MouseEnter);
            this.btn_Reset.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            frm_PeopleMgmt.hintBox});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // hintBox
            // 
            frm_PeopleMgmt.hintBox.Name = "hintBox";
            frm_PeopleMgmt.hintBox.Size = new System.Drawing.Size(32, 17);
            frm_PeopleMgmt.hintBox.Text = "状态";
            // 
            // dgv_People
            // 
            frm_PeopleMgmt.dgv_People.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            frm_PeopleMgmt.dgv_People.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            frm_PeopleMgmt.dgv_People.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            frm_PeopleMgmt.dgv_People.Location = new System.Drawing.Point(12, 12);
            frm_PeopleMgmt.dgv_People.Name = "dgv_People";
            frm_PeopleMgmt.dgv_People.RowTemplate.Height = 23;
            frm_PeopleMgmt.dgv_People.Size = new System.Drawing.Size(661, 336);
            frm_PeopleMgmt.dgv_People.TabIndex = 7;
            frm_PeopleMgmt.dgv_People.MouseEnter += new System.EventHandler(frm_PeopleMgmt.dgv_People_MouseEnter);
            // 
            // frm_PeopleMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 402);
            this.Controls.Add(frm_PeopleMgmt.dgv_People);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Search);
            this.MinimumSize = new System.Drawing.Size(440, 440);
            this.Name = "frm_PeopleMgmt";
            this.Text = "人员档案管理";
            this.Load += new System.EventHandler(this.frm_PeopleMgmt_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(frm_PeopleMgmt.dgv_People)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private static System.Windows.Forms.ToolStripStatusLabel hintBox;
        private static System.Windows.Forms.DataGridView dgv_People;
    }
}