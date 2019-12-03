using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsScore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtName.Focus();
        }
        private void btnOK_Click(object sender,EventArgs e)
        {
            string username, password;
            string strSql = "";
            DataSet ds;
            if(txtName.Text.Trim()!="" && txtPwd.Text.Trim() != "")
            {
                username = txtName.Text.Trim();     password = txtPwd.Text.Trim();
                strSql = "select * from Userinfo where Userid = '" + username + "' and Userpwd='" + password + "'";
                DataAccess data = new DataAccess();
                data.dataCon();
                ds = data.getDataset(strSql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    frmMain fMain = new frmMain();
                    fMain.Show();
                    this.Hide();
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
        private void btnExit_Click(object sender , EventArgs e)
        {
            Application.Exit();
        }
    }
}
