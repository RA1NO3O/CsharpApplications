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
    public partial class frmManageScore : Form
    {
        public frmManageScore()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtSid.Text != "")
            {
                condition += "and Studentinfo.Sid='" + txtSid.Text + "'";
            }
            if (txtSname.Text != "")
            {
                condition += "and Sname='" + txtSname.Text + "'";
            }
            if (txtCid.Text != "")
            {
                condition += "and Cid='" + txtCid.Text + "'";
            }
            strSql = "SELECT Courseinfo.Cid AS 课程号 , Courseinfo.Cname AS 课程名称 , Studentinfo.Sname AS 姓名 , Studentinfo.Class AS 班级 , Studentinfo.Sid AS 学号 , Scoreinfo.Score AS 成绩 FROM Studentinfo , Courseinfo , Scoreinfo WHERE Courseinfo.Cid=Scoreinfo.Cid AND Studentinfo.Sid = Scoreinfo.Sid" + condition;
            data.dataCon();
            ds = data.getDataset(strSql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "DELETE FROM Scoreinfo WHERE Cid = '" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "' AND Sid='" + dgvInfo.CurrentRow.Cells[4].Value.ToString() + "'";
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
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "UPDATE Scoreinfo SET Score = '" + dgvInfo.CurrentRow.Cells[5].Value.ToString() + "' WHERE Sid = '" + dgvInfo.CurrentRow.Cells[4].Value.ToString() + "' AND Cid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
            data.dataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("修改成功!!");
            }
            else
            {
                MessageBox.Show("修改失败!!");
            }
        }
    }
}
