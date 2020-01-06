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
    public partial class frm_SalaryAdd : Form
    {
        public frm_SalaryAdd()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Length == 0 && txt_BS.Text.Length == 0 && txt_ES.Text.Length == 0)
            {
                string strSql;
                DataConnector data = new DataConnector();
                strSql = "insert into Salary ( ID , BS , Tax , ES ) values('" + txt_ID.Text + "','" + txt_BS.Text + "','" + txt_tax.Text + "','" + txt_ES.Text + "')";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("添加成功!!\r\n表中数据将会更新.", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败!!\r\n请确认输入的数据.", "关键性错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("必须的字段未满足!!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";txt_BS.Text = "";txt_tax.Text = "";txt_ES.Text = "";
        }
    }
}
