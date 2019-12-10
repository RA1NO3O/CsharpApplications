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
    public partial class frmEditStu : Form
    {
        public frmEditStu()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strsql = "";
            if (txtSname.Text != "" && txtBirthday.Text != "" && txtClass.Text != "" && txtTel.Text != "" && txtAddress.Text != "" && cboSex.Text != "")
            {
                strsql = "update Studentinfo set Sname ='" + txtSname.Text + " ',Sex = '" + cboSex.Text + "',Birthday='" + txtBirthday.Text + "',Class='" + txtClass.Text + "',Tel='" + txtTel.Text + "',Address='" + txtAddress.Text + "'where Sid='" + frmManageStu.Sid + "'";
                DataAccess data = new DataAccess();
                data.dataCon(); 
                if (data.sqlExec(strsql))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            else
            {
                MessageBox.Show("输入未完全!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditStu_Load(object sender, EventArgs e)
        {
            txtSid.Text = frmManageStu.sid;
            txtSname.Text = frmManageStu.sname;
            cboSex.Text = frmManageStu.sex;
            txtBirthday.Text = frmManageStu.birthday;
            txtClass.Text = frmManageStu.classname;
            txtTel.Text = frmManageStu.tel;
            txtAddress.Text = frmManageStu.address;
        }
    }
}
