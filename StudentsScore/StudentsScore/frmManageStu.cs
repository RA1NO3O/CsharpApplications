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
    public partial class frmManageStu : Form
    {
        public frmManageStu()
        {
            InitializeComponent();
        }
        public static string sid;
        public static string Sid
        {
            get { return sid; }
            set { sid = value; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtSid.Text != "")
            {
                condition += "and Sid='" + txtSid.Text + "'";
            }
            if (txtSname.Text != "")
            {
                condition += "and Sname='" + txtSname.Text + "'";
            }
            if (txtClass.Text != "")
            {
                condition += "and Class='" + txtClass.Text + "'";
            }
            if (cboSex.Text != "")
            {
                condition += "and Sex='" + cboSex.Text + "'";
            }
            strSql="SELECT Sid AS 学号 , Snamne AS 姓名 , Sex AS 性别 , Birthday AS 出生日期 , Class AS 班级 , Tel AS 电话 , Address AS 家庭住址 FROM Studentinfo WHERE 1=1"
        }
    }
}
