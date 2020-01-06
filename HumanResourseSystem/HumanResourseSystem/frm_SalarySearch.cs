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
    public partial class frm_SalarySearch : Form
    {
        public static string strSql;
        public frm_SalarySearch()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            string condiction = "";
            if (chk_LIKEMODE.Checked == false) 
            {
                if (txt_ID.Text.Length == 0) { condiction += "and ID='" + txt_ID.Text + "'"; }
                if (txt_BasicSalary.Text.Length == 0) { condiction += "and BS='" + txt_ID.Text + "'"; }
                if (textBox1.Text.Length == 0) { condiction += "and Tax='" + textBox1.Text + "'"; }
                if (textBox2.Text.Length == 0) { condiction += "and ES='" + textBox2.Text + "'"; }
            }
            else
            {
                if (txt_ID.Text.Length == 0) { condiction += "and ID LIKE '%" + txt_ID.Text + "%'"; }
                if (txt_BasicSalary.Text.Length == 0) { condiction += "and BS LIKE '%" + txt_ID.Text + "%'"; }
                if (textBox1.Text.Length == 0) { condiction += "and Tax LIKE '%" + textBox1.Text + "%'"; }
                if (textBox2.Text.Length == 0) { condiction += "and ES LIKE '%" + textBox2.Text + "%'"; }
            }
            strSql = "SELECT ID AS  编号 , BS AS 基本工资 , Tax AS 应缴税 , ES AS 实发工资 FROM Salary WHERE 1=1 " + condiction;
            frm_SalaryMgmt.frm_SM.ExecSQL();
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";txt_BasicSalary.Text = "";textBox1.Text = "";textBox2.Text = "";
        }
    }
}
