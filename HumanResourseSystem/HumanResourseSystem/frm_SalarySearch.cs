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
            if (txt_ID.Text != "") { condiction += "and ID='" + txt_ID.Text + "'"; }
            if (txt_BasicSalary.Text != "") { condiction += "and BS='" + txt_ID.Text + "'"; }
            if (textBox1.Text != "") { condiction += "and Tax='" + textBox1.Text + "'"; }
            if (textBox2.Text != "") { condiction += "and ES='" + textBox2.Text + "'"; }
            strSql = "SELECT * FROM Salary WHERE 1=1 " + condiction;
            frm_SalaryMgmt.frm_SM.ExecSQL();
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";txt_BasicSalary.Text = "";textBox1.Text = "";textBox2.Text = "";
        }
    }
}
