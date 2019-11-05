using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学号为:" + txtID.Text + ",姓名为:" + txtName.Text + "\r\n性别为:" + cboSex.SelectedItem.ToString() + ",年龄为:" + txtAge.Text + "\r\n民族为:" + txtNation.Text + ",籍贯为:" + txtBirthplace.Text + "\r\n院系为:" + cboDepartment.SelectedItem.ToString() + "专业为:" + txtMajor.Text + "\r\n班级为:" + txtClass.Text + ",年级为:" + cboGrade.SelectedItem.ToString() + "\r\n奖励为:" + txtRewards.Text + "\r\n惩罚为:" + txtPunishment.Text, "学生档案信息");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "";    txtName.Text = "";
            cboSex.Text="";  txtAge.Text = "";
            txtNation.Text = "";    txtBirthplace.Text = "";
            cboDepartment.Text = "";
            txtMajor.Text = "";     txtClass.Text = "";
            cboGrade.SelectedItem=-1;    txtRewards.Text = "";
            txtPunishment.Text = "";
        }
    }
}
