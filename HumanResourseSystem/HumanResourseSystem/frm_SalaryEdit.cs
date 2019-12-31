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
    public partial class frm_SalaryEdit : Form
    {
        public frm_SalaryEdit()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            if (txt_ID.TextLength != 0 && txt_BS.TextLength != 0 && txt_ES.TextLength != 0) {
                string strSql;
                DataConnector data = new DataConnector();
                strSql = $"UPDATE Salary SET BS = '{txt_BS.Text}' , Tax = '{txt_tax.Text}' , ES = '{txt_ES.Text}' WHERE ID= '{txt_ID.Text}'";
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

        private void frm_SalaryEdit_Load(object sender, EventArgs e)
        {
            txt_ID.Text = frm_SalaryMgmt.Id;
            txt_BS.Text = frm_SalaryMgmt.Bs;
            txt_tax.Text = frm_SalaryMgmt.Tax;
            txt_ES.Text = frm_SalaryMgmt.Es;

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            frm_SalaryEdit_Load(sender, e);
        }

        private void txt_BS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) { this.Close(); }
        }
    }
}
