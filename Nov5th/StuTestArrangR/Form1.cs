using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuTestArrangR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tvwCourse_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "大学英语":
                    lvwInformation.Items.Clear();
                    ListViewItem item1 = new ListViewItem(e.Node.Text);
                    item1.SubItems.Add("6月3号 9:00--11:00");
                    item1.SubItems.Add("教学楼101--111");
                    lvwInformation.Items.Add(item1);
                    break;
                case "高等数学":
                    lvwInformation.Items.Clear();
                    ListViewItem item2 = new ListViewItem(e.Node.Text);
                    item2.SubItems.Add("6月3号 14:00--16:00");
                    item2.SubItems.Add("教学楼101--111");
                    lvwInformation.Items.Add(item2);
                    break;
                case "信息技术":
                    lvwInformation.Items.Clear();
                    ListViewItem item3 = new ListViewItem(e.Node.Text);
                    item3.SubItems.Add("6月4号 9:00--11:00");
                    item3.SubItems.Add("教学楼501--511");
                    lvwInformation.Items.Add(item3);
                    break;
                case "数据库技术与应用":
                    lvwInformation.Items.Clear();
                    ListViewItem item4 = new ListViewItem(e.Node.Text);
                    item4.SubItems.Add("6月3号 9:00--11:00");
                    item4.SubItems.Add("教学楼501--511");
                    lvwInformation.Items.Add(item4);
                    break;
                case "C#程序设计":
                    lvwInformation.Items.Clear();
                    ListViewItem item5 = new ListViewItem(e.Node.Text);
                    item5.SubItems.Add("6月3号 14:00--16:00");
                    item5.SubItems.Add("教学楼501--511");
                    lvwInformation.Items.Add(item5);
                    break;
            }
        }
    }
}
