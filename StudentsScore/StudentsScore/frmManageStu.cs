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
        public static string sname;
        public static string Sname
        {
            get { return sname; }
            set { sname = value; }
        }
        public static string classname;
        public static string ClassName
        {
            get { return classname; }
            set { classname = value; }
        }
        public static string sex;
        public static string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public static string birthday;
        public static string Birthday
        {
            get { return birthday; }
            set { sex = value; }
        }
        public static string tel;
        public static string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public static string address;
        public static string Address
        {
            get { return address; }
            set { address = value; }
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
            strSql = "SELECT Sid AS 学号 , Sname AS 姓名 , Sex AS 性别 , Birthday AS 出生日期 , Class AS 班级 , Tel AS 电话 , Address AS 家庭住址 FROM Studentinfo WHERE 1=1"+condition;

            data.dataCon();
            ds = data.getDataset(strSql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "DELETE FROM Studentinfo WHERE Sid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
            data.dataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("删除成功!!");
            }
            else
            {
                MessageBox.Show("删除失败!!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmManageStu.sid = dgvInfo.CurrentRow.Cells[0].Value.ToString();
            frmManageStu.sname = dgvInfo.CurrentRow.Cells[1].Value.ToString();
            frmManageStu.sex = dgvInfo.CurrentRow.Cells[2].Value.ToString();
            frmManageStu.birthday = dgvInfo.CurrentRow.Cells[3].Value.ToString();
            frmManageStu.classname = dgvInfo.CurrentRow.Cells[4].Value.ToString();
            frmManageStu.tel = dgvInfo.CurrentRow.Cells[5].Value.ToString();
            frmManageStu.address = dgvInfo.CurrentRow.Cells[6].Value.ToString();
            frmEditStu frmEditStu1 = new frmEditStu();
            frmEditStu1.Show();
        }
    }
}
