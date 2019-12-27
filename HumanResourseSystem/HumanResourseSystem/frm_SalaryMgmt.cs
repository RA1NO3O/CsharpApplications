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
        public static frm_SalaryMgmt frm_SM;
        public frm_SalaryMgmt()
        {
            InitializeComponent();
            frm_SM = this;
        }

        public static string Id { get => id; set => id = value; }
        public static string Bs { get => bs; set => bs = value; }
        public static string Tax { get => tax; set => tax = value; }
        public static string Es { get => es; set => es = value; }

        private static string id;
        private static string bs;
        private static string tax;
        private static string es;

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
            strSql = "SELECT ID AS 编号 , BS AS 基本工资 , Tax AS 应缴税 , ES AS 实发工资 FROM Salary";
            data.dataCon();
            ds = data.getDataset(strSql);
            dgv_Salary.DataSource = ds.Tables[0];
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除选中的记录吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string strSql;
                DataConnector data = new DataConnector();
                strSql = "delete from Salary where ID='" + dgv_Salary.CurrentRow.Cells[0].Value.ToString() + "'";
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
            id = dgv_Salary.CurrentRow.Cells[0].Value.ToString();
            bs = dgv_Salary.CurrentRow.Cells[1].Value.ToString();
            tax = dgv_Salary.CurrentRow.Cells[2].Value.ToString();
            es = dgv_Salary.CurrentRow.Cells[3].Value.ToString();
            frm_SalaryEdit E = new frm_SalaryEdit();
            E.ShowDialog();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_SalaryAdd A = new frm_SalaryAdd();
            A.ShowDialog();
            refresh();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_SalarySearch S = new frm_SalarySearch();
            S.ShowDialog();
        }
        public void ExecSQL()
        {
            DataConnector data = new DataConnector();
            DataSet ds;
            data.dataCon();
            ds = data.getDataset(frm_SalarySearch.strSql);
            dgv_Salary.DataSource = ds.Tables[0];
        }
    }
}
