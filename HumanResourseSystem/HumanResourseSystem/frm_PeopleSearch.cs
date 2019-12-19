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
            if (txt_ID.Text != "") { condition += "and 编号='" + txt_ID.Text + "'"; }
            if (txt_Sex.Text != "") { condition += "and 性别='" + txt_Sex.Text + "'"; }
            if (txt_Age.Text != "") { condition += "and 年龄='" + txt_Age.Text + "'"; }
            if (txt_Position.Text != "") { condition += "and 就职岗位='" + txt_Position.Text + "'"; }
            if (txt_Phone.Text != "") { condition += "and 电话='" + txt_Phone.Text + "'"; }
            if (txt_Address.Text != "") { condition += "and 住址='" + txt_Address.Text + "'"; }
            strSql = "SELECT * FROM Employee WHERE 1=1 " + condition;
            frm_PeopleMgmt.ExecSQL();
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";txt_Sex.Text = "";txt_Age.Text = ""; txt_Position.Text = "";txt_Phone .Text= "";txt_Address.Text = "";
        }
    }
}
