using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourseSystem
{
    public partial class frm_Login : Form
    {
        public static string username, password, permission;
        public frm_Login()
        {

            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {       //登录按钮事件
            string strSql = "";
            DataSet ds;
            if (txt_Username.Text.Trim() != ""&&txt_Password.Text.Trim()!="")
            {
                username = txt_Username.Text.Trim(); password = txt_Password.Text.Trim();
                strSql = "select * from LoginUsers where username = '" + username + "' and password='" + password + "'";
                if (txt_Password.Text.Equals("")) { strSql = "select * from LoginUsers where username = '" + username + "'"; }
                DataConnector data = new DataConnector();
                data.dataCon();
                ds = data.getDataset(strSql);
                
                if (ds.Tables[0].Rows.Count == 1)
                {
                    permission = ds.Tables[0].Rows[0][2].ToString();    //获取SELECT视图中的单个记录信息
                    frm_Main fMain = new frm_Main();
                    fMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！\r\n请重新输入.", "登录失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_Password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("用户名或密码为空，请输入完整的登录凭据.", "提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {       //按下键事件
            label2.Text = "最后的按键值:"+e.KeyValue.ToString();
            if (e.KeyValue == 13) { btn_Login_Click(sender,e); }
            if (e.KeyValue == 27) { Application.Exit(); }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {   //初始化 
            label2.Text = "";
        }
    }
}
