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
    public partial class frm_PeopleSearch : Form
    {
        public static string strSql;
        public frm_PeopleSearch()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            string condition = "";
            if (txt_ID.Text != "") { condition += "and E_ID='" + txt_ID.Text + "'"; }
            if (txt_Name.Text != "") { condition += "and E_EName='" + txt_Name + "'"; }
            if (txt_Sex.Text != "") { condition += "and E_Sex='" + txt_Sex.Text + "'"; }
            if (txt_Birthday.Text != "") { condition += "and E_Birthday='" + txt_Birthday.Text + "'"; }
            if (txt_Inworkdate.Text != "") { condition += "and E_InworkDate='" + txt_Inworkdate.Text + "'"; }
            if (txt_Age.Text != "") { condition += "and E_Age='" + txt_Age.Text + "'"; }
            if (txt_Position.Text != "") { condition += "and E_Position='" + txt_Position.Text + "'"; }
            if (txt_Phone.Text != "") { condition += "and E_Tel='" + txt_Phone.Text + "'"; }
            if (txt_Address.Text != "") { condition += "and E_Address='" + txt_Address.Text + "'"; }
            strSql = "SELECT   E_ID AS 编号, E_Name AS 姓名, E_Sex AS 性别, E_Age AS 年龄, E_Birthday AS 出生日期, E_InworkDate AS 入职日期, E_Position AS 岗位, E_Phone AS 电话, E_Address AS 地址 FROM      Employee WHERE 1=1 " + condition;
            frm_PeopleMgmt.ExecSQL();
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";txt_Sex.Text = "";txt_Age.Text = ""; txt_Position.Text = "";txt_Phone .Text= "";txt_Address.Text = "";
        }

        private void frm_PeopleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) { btn_Execute_Click(sender, e); }
        }
    }
}
