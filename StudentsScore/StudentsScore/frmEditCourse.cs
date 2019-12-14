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
    public partial class frmEditCourse : Form
    {
        public frmEditCourse()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strSql = "";
            if (txtCid.Text != "" && txtCname.Text != "" && txtCredit.Text != "")
            {
                strSql = "update Courseinfo get Cname='" + txtCname.Text + "',Credit='" + txtCredit.Text + "' where Cid='" + frmManageCourse.cid + "'";
                DataAccess data = new DataAccess();
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
            else
            {
                MessageBox.Show("输入未完全!!");
            }
        }

        private void frmEditCourse_Load(object sender, EventArgs e)
        {
            txtCid.Text = frmManageCourse.cid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
