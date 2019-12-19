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
    public partial class frm_SalaryMgmt : Form
    {
        public frm_SalaryMgmt()
        {
            InitializeComponent();
        }

        private void frm_SalaryMgmt_Load(object sender, EventArgs e)
        {
            if (frm_Login.permission.Equals("ReadOnly"))
            {   //检索权限
                btn_Add.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Edit.Enabled = false;
            }
            refresh();
        }
        private void refresh()
        {   //重载表
            string strSql;
            DataConnector data = new DataConnector();
            DataSet ds;
            strSql = "SELECT * FROM Salary";
            data.dataCon();
            ds = data.getDataset(strSql);
            dgv_People.DataSource = ds.Tables[0];
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除选中的记录吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string strSql;
                DataConnector data = new DataConnector();
                strSql = "delete from Employee where 编号='" + dgv_People.CurrentRow.Cells[0].Value.ToString() + "'";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("删除成功\r\n表中数据将会更新.", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("删除失败!!", "结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frm_SalaryEdit E = new frm_SalaryEdit();
            E.ShowDialog();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_SalaryAdd A = new frm_SalaryAdd();
            A.ShowDialog();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
