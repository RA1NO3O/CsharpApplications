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
        private Boolean showpwd=false;
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
                
                if (ds.Tables[0].Rows.Count == 1)   //判断是否查询到一个用户.
                {
                    permission = ds.Tables[0].Rows[0][2].ToString();    //获取用户权限等级
                    frm_Main fMain = new frm_Main();
                    fMain.Show();   //显示主窗体.
                    this.Hide();    //隐藏登录窗体.
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

        private void button1_Click(object sender, EventArgs e)
        {   //显示或隐藏密码字符
            if (!showpwd) { txt_Password.PasswordChar =default;button1.Text = "隐藏";showpwd = true; }
            else if (showpwd) { txt_Password.PasswordChar = '•';button1.Text = "显示"; showpwd = false; }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {   //清空用户名
            txt_Username.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {   //此控件仅为方便开发使用,单击即可隐藏.
            label2.Visible = false;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {       //按下键事件
            label2.Text = "最后的按键值:"+e.KeyValue.ToString();
            if (e.KeyValue == 13) { btn_Login_Click(sender,e); }
            if (e.KeyValue == 27) { Application.Exit(); }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            label2.Text = "";   label2.Visible = true;
        }
    }
}
