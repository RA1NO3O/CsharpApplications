using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dec17th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            string strSql = "";
            DataSet ds;
            if (txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                username = txtUsername.Text.Trim(); password = txtPassword.Text.Trim();
                strSql = "select * from yhb where name = '" + username + "' and pwd='" + password + "'";
                DataConnection data = new DataConnection();
                data.dataCon();
                ds = data.getDataset(strSql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("登录成功！");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "登录失败");
                }
            }
            else
            {
                MessageBox.Show("用户名或密码为空，请输入信息", "提示");
            }
        }
    }
}
