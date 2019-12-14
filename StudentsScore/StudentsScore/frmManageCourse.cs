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
    public partial class frmManageCourse : Form
    {
        public static string cid;
        public static string Cid
        {
            get { return cid; }
            set { cid = value; }
        }
        public frmManageCourse()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtCid.Text != "")
            {
                condition += "and Cid=;" + txtCid.Text + "'";
            }
            if (txtCname.Text != "")
            {
                condition += "and Cname='" + txtCname.Text + "'";
            }
            strSql = "SELECT Cid AS 课程编号 , Cname AS 课程名称 , Credit AS 学分 FROM Courseinfo WHERE 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strSql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "delete from Courseinfo where Cid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
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
            frmManageCourse.cid = dgvInfo.CurrentRow.Cells[0].Value.ToString();
            frmEditCourse frmEditCourse1 = new frmEditCourse();
            frmEditCourse1.Show();
        }
    }
}
