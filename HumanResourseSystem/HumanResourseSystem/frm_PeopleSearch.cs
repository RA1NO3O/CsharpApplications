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
            if (txt_ID.Text != "") { condition += "and ID='" + txt_ID.Text + "'"; }
            if (txt_Name.Text != "") { condition += "and EName='" + txt_Name + "'"; }
            if (txt_Sex.Text != "") { condition += "and Sex='" + txt_Sex.Text + "'"; }
            if (txt_Birthday.Text != "") { condition += "and Birthday='" + txt_Birthday.Text + "'"; }
            if (txt_Inworkdate.Text != "") { condition += "and InworkDate='" + txt_Inworkdate.Text + "'"; }
            if (txt_Age.Text != "") { condition += "and Age='" + txt_Age.Text + "'"; }
            if (txt_Position.Text != "") { condition += "and Position='" + txt_Position.Text + "'"; }
            if (txt_Phone.Text != "") { condition += "and Tel='" + txt_Phone.Text + "'"; }
            if (txt_Address.Text != "") { condition += "and Address='" + txt_Address.Text + "'"; }
            strSql = "SELECT * FROM Employee WHERE 1=1 " + condition;
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
