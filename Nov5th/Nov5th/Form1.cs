using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nov5th
{
    public partial class Form1 : Form
    {
        String answer1, answer2, answer3, answer4;



        public Form1()
        {
            InitializeComponent();
            
            String[] lstAnsweritem = new String[] {"不知道如何处理人际关系","不知道如何处理恋爱问题","不知道如何分配空余时间","不知道怎样学好专业课","不知道怎样做好大学规划","其他"};
            lstAnswer.Items.AddRange(lstAnsweritem);
            String[] cboAnswerItem = new String[] {"学习","人际关系","工作经验","其他" };
            cboAnswer.Items.AddRange(cboAnswerItem);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            rbtnAnswer1.Checked = false;    rbtnAnswer2.Checked = false;    rbtnAnswer3.Checked = false;    rbtnAnswer4.Checked = false;
            chkAnswer1.Checked = false; chkAnswer2.Checked = false; chkAnswer3.Checked = false; chkAnswer4.Checked = false;
            cboAnswer.Text = "";
            lstAnswer.SelectedItems.Clear();
            lstResult.Items.Clear();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            answer3 = lstAnswer.SelectedItem.ToString();    answer4 = cboAnswer.Text;
            String[] lstResultItem = new String[] { "第一个问题答案:"+answer1, "第二个问题答案:"+answer2, "第三个问题答案:"+answer3, "第四个问题答案:"+answer4 };
            lstResult.Items.AddRange(lstResultItem);
        }

        private void rbtnAnswer_CheckedChanged(object sender, EventArgs e)
        {
                   if (rbtnAnswer1.Checked) { answer1 = rbtnAnswer1.Text; }
            else if (rbtnAnswer2.Checked) { answer1 = rbtnAnswer2.Text; } 
            else if (rbtnAnswer3.Checked) { answer1 = rbtnAnswer3.Text; }
            else if (rbtnAnswer4.Checked) { answer1 = rbtnAnswer4.Text; };
        }
        private void chkAnswer_CheckedChanged(object sender, EventArgs e)
        {
                   if (chkAnswer1.Checked) { answer2 = chkAnswer1.Text; }
            else if (chkAnswer2.Checked) { answer2 = chkAnswer2.Text; }
            else if (chkAnswer3.Checked) { answer2 = chkAnswer3.Text; }
            else if (chkAnswer4.Checked) { answer2 = chkAnswer4.Text; };
        }
    }
}