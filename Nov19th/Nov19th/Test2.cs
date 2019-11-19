using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nov19th
{
    public partial class Test2 : Form
    {
        public Test2()
        {
           
            InitializeComponent();
            label7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
            textBox2.Clear(); 
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label7.Text = "";
        }
        private void Display()
        {
            CStudent a = new CStudent();
            if (a.StuName.Equals("#ERROR")) { MessageBox.Show("姓名格式错误","错误", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { a.StuName = textBox1.Text; }
            if (a.StuNation.Equals("#ERROR")) { MessageBox.Show("籍贯格式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { a.StuNation = textBox2.Text; }
            if (a.StuID.Equals("#ERROR")) { MessageBox.Show("学号格式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { a.StuName = textBox3.Text; }
            if (a.StuAge==0) { MessageBox.Show("年龄格式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { a.StuAge = Convert.ToInt32(textBox4.Text); }
            if (a.StuScoreGrade==0) { MessageBox.Show("成绩格式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { a.StuScoreGrade = Convert.ToInt32(textBox5.Text); }

           

            label7.Text = "你的姓名是：" + textBox1.Text + "\r\n你的籍贯是：" + textBox2.Text + "\r\n你的学号是：" + textBox3.Text + "\r\n你的年龄是：" + textBox4.Text + "\r\n你的成绩排名是：" + textBox5.Text + "\r\n你的导师姓名是：" + textBox6.Text;
        }
    }
}
