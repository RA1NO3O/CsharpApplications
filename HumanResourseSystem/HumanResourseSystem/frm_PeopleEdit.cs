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
        {   //从frm_PeopleMgmt获取数据
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
            if (txt_ID.TextLength != 0 && txt_Name.TextLength != 0 && txt_Sex.Text.Length != 0 && txt_Birthday.TextLength != 0 && txt_Inworkdate.TextLength != 0)
            {
                string strSql;
                DataConnector data = new DataConnector();
                strSql = $"UPDATE Employee SET E_Name = '{txt_Name.Text}' , E_Sex = '{txt_Sex.Text}' , E_Age = '{txt_Age.Text}' , E_Birthday = '{txt_Birthday.Text}' , E_InworkDate = '{txt_Inworkdate.Text}' , E_Position = '{txt_Position.Text}' , E_Phone = '{txt_Phone.Text}' , E_Address = '{txt_Address.Text}' WHERE E_ID= '{txt_ID.Text}'";
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
                MessageBox.Show("必须的字段未满足!!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_PeopleEdit_KeyDown(object sender, KeyEventArgs e)
        {   //用户按下Esc键
            if (e.KeyValue == 27) { this.Close(); }
        }
    }
}
