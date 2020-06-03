using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBServiceSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ServiceController mssql = new ServiceController("MSSQLSERVER");
            ServiceController mysql = new ServiceController("MySQL80");
            string statusHint = "未执行任何操作,退出.";
            if (e.KeyChar == '1')
            {
                if (mssql.Status.Equals(ServiceControllerStatus.Stopped)) { 
                    mssql.Start();
                    mssql.WaitForStatus(ServiceControllerStatus.Running);
                    statusHint = "SQL Server 服务已成功启动.\n";
                }
                else { statusHint = "SQL Server 服务未处于停止状态.\n"; }
                if (mysql.Status.Equals(ServiceControllerStatus.Stopped)) { 
                    mysql.Start();
                    mysql.WaitForStatus(ServiceControllerStatus.Running);
                    statusHint += "MySQL 8.0 服务已成功启动.";
                }
                else { statusHint += "MySQL 8.0 服务未处于停止状态."; }
            }
            if (e.KeyChar == '2')
            {
                if (mssql.Status.Equals(ServiceControllerStatus.Running)) {
                    mssql.Stop();
                    statusHint = "SQL Server 服务已成功停止.\n";
                }
                else { statusHint = "SQL Server 服务未处于运行状态.\n"; }
                if (mysql.Status.Equals(ServiceControllerStatus.Running)) {
                    mysql.Stop();
                    statusHint += "MySQL 8.0 服务已成功停止.";
                }
                else { statusHint += "MySQL 8.0 服务未处于运行状态."; }
            }
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000, "信息:", statusHint, ToolTipIcon.Info);
            Application.Exit();
        }
    }
}
