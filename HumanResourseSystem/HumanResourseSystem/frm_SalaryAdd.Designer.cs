namespace HumanResourseSystem
{
    partial class frm_SalaryAdd
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
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ES = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(32, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "标\"*\"的为必填字段.";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.Location = new System.Drawing.Point(370, 229);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "重置(&R)";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "编号*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(70, 3);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(159, 21);
            this.txt_ID.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "基本工资*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_BS
            // 
            this.txt_BS.Location = new System.Drawing.Point(325, 3);
            this.txt_BS.Name = "txt_BS";
            this.txt_BS.Size = new System.Drawing.Size(200, 21);
            this.txt_BS.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "应缴税";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ES
            // 
            this.txt_ES.Location = new System.Drawing.Point(325, 29);
            this.txt_ES.Name = "txt_ES";
            this.txt_ES.Size = new System.Drawing.Size(200, 21);
            this.txt_ES.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "实发工资*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.87931F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.12069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_BS, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_ES, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_tax, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 55);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(70, 29);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(159, 21);
            this.txt_tax.TabIndex = 31;
            // 
            // btn_Execute
            // 
            this.btn_Execute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Execute.Location = new System.Drawing.Point(235, 229);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(75, 23);
            this.btn_Execute.TabIndex = 9;
            this.btn_Execute.Text = "完成(&F)";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 192);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "录入信息";
            // 
            // frm_SalaryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 267);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_SalaryAdd";
            this.Text = "新增工资记录";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tax;
    }
}