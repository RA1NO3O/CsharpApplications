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
    public partial class frm_PeopleEdit : Form
    {
        public frm_PeopleEdit()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            frm_PeopleEdit_Load(sender, e);
        }

        private void frm_PeopleEdit_Load(object sender, EventArgs e)
        {
            txt_ID.Text = frm_PeopleMgmt.Id;
            txt_Name.Text = frm_PeopleMgmt.E_Name;
            txt_Sex.Text = frm_PeopleMgmt.Sex;
            txt_Age.Text = frm_PeopleMgmt.Age;
            txt_Birthday.Text = frm_PeopleMgmt.Birthday;
            txt_Inworkdate.Text = frm_PeopleMgmt.Inworkdate;
            txt_Position.Text = frm_PeopleMgmt.Position;
            txt_Phone.Text = frm_PeopleMgmt.Phone;
            txt_Address.Text = frm_PeopleMgmt.Address;
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_Name.Text != "" && txt_Sex.Text != "" && txt_Birthday.Text != "" && txt_Inworkdate.Text != "")
            {
                string strSql;
                DataConnector data = new DataConnector();
                strSql = "update Employee set 姓名='" + txt_Name.Text + "' , 性别='" + txt_Sex.Text + "' , 年龄='" + txt_Age.Text + "' , 出生日期='" + txt_Birthday.Text + "' , 入职日期='" + txt_Inworkdate.Text + "' , 就职岗位='" + txt_Position.Text + "' , 电话='" + txt_Phone.Text + "' , 住址='" + txt_Address.Text + "' where 编号='" + frm_PeopleMgmt.Id + "'";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("修改成功!!\r\n表中数据将会更新.", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败!!\r\n请确认输入的数据.", "关键性错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("必须的字段未满足!!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
