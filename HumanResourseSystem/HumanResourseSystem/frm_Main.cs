using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourseSystem
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {       //窗体关闭后事件
            Application.Exit();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 人员档案管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PeopleMgmt frmPM = new frm_PeopleMgmt();
            frmPM.MdiParent = this;
            frmPM.Show();
        }

        private void 人员工资管理SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SalaryMgmt frmSM = new frm_SalaryMgmt();
            frmSM.MdiParent = this;
            frmSM.Show();
        }

        private void 人员系统管理YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SysMgmt frmYM = new frm_SysMgmt();
            frmYM.MdiParent = this;
            frmYM.Show();
        }

        private void 数据库管理TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Directory.GetCurrentDirectory()+"\\Resources\\HR.accdb");
        }

        private void Items_MouseLeave(object sender, EventArgs e)
        {
            hintbox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ms_QuickAdd.Show(MousePosition);
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("你确定要退出吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== System.Windows.Forms.DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void 关于AToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text = "显示帮助菜单.";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text = "单击可快速向数据库添加内容.";
        }

        private void 系统SToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text = "显示系统菜单.";
        }

        private void 关于AToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text = "显示与此应用程序以及开发人员的相关信息.";
        }

        private void 系统信息SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process WinSPro = new Process();
            ProcessStartInfo WinSSInfo = new ProcessStartInfo();
            WinSSInfo.FileName = "winver.exe";
            WinSPro.StartInfo = WinSSInfo;
            WinSPro.Start();
        }

        private void 人员档案管理ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text="打开''人员档案管理''子窗口.";
        }

        private void 人员工资管理SToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text = "打开''人员工资管理''子窗口.";
        }

        private void 人员系统管理YToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text = "打开''人员系统管理''子窗口.";
        }

        private void 数据库管理TToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text = "打开数据库文件并直接对其进行修改.";
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            hintbox.Text = "欢迎,"+frm_Login.username+".  您的管理权限:"+frm_Login.permission;
            this.Text = "人事工资管理系统  " + "  当前用户:" + frm_Login.username + "  登录时间:" + DateTime.Now;
            if (frm_Login.permission.Equals("ReadOnly")) { 数据库管理TToolStripMenuItem.Enabled = false; }
        }

        private void 退出ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text = "退出本系统.";
        }

        private void 偏好设置PToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            hintbox.Text = "对程序进行个性化设置.";
        }

        private void 登出LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要登出吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                frm_Login login = new frm_Login();
                login.Text = "您已登出,请重新登录.";
                login.Show();
            }
        }

        private void 添加人员档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PeopleAdd pa = new frm_PeopleAdd();
            pa.ShowDialog();
        }
    }
}
