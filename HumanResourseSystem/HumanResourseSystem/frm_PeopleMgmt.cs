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
    public partial class frm_PeopleMgmt : Form
    {
        public frm_PeopleMgmt()
        {
            InitializeComponent();
        }
        public static string Id { get => id; set => id = value; }
        public static string E_Name { get => e_name; set => e_name = value; }
        public static string Sex { get => sex; set => sex = value; }
        public static string Age { get => age; set => age = value; }
        public static string Birthday { get => birthday; set => birthday = value; }
        public static string Inworkdate { get => inworkdate; set => inworkdate = value; }
        public static string Position { get => position; set => position = value; }
        public static string Phone { get => phone; set => phone = value; }
        public static string Address { get => address; set => address = value; }
        private static string address;
        private static string phone;
        private static string position;
        private static string inworkdate;
        private static string birthday;
        private static string sex;
        private static string age;
        private static string id;
        private static string e_name;
        private void frm_PeopleMgmt_Load(object sender, EventArgs e)
        {
            if (frm_Login.permission.Equals("ReadOnly"))
            {   //检索权限
                btn_Add.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Edit.Enabled = false;
            }
            refresh();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            refresh();
            hintBox.Text = "已重载人员档案表视图.";
        }

        private void Items_MouseLeave(object sender, EventArgs e)
        {
            hintBox.Text = "";
        }

        private void dgv_People_MouseEnter(object sender, EventArgs e)
        {
            if (frm_Login.permission.Equals("ReadOnly")){ hintBox.Text = "鉴于当前用户访问权限等级,这些数据是只读的,您没有权限修改它们."; }
            else { hintBox.Text = "请注意,对表中内容的修改并不会影响到数据库.若要操作这些数据,请使用右下角的''添加'',''修改''和''删除''按钮."; }
            
        }

        private void btn_Search_MouseEnter(object sender, EventArgs e)
        {
            hintBox.Text = "查找或筛选特定的符合表达式的数据,并显示在此窗口中.";
        }

        private void btn_Reset_MouseEnter(object sender, EventArgs e)
        {
            hintBox.Text = "单击以重新载入数据表.";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("你确定要删除选中的记录吗?","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== System.Windows.Forms.DialogResult.Yes) {
                string strSql;
                DataConnector data = new DataConnector();
                strSql = "delete from Employee where 编号='" + dgv_People.CurrentRow.Cells[0].Value.ToString() + "'";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("删除成功\r\n表中数据将会更新.","结果",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("删除失败!!", "关键性错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_PeopleAdd A = new frm_PeopleAdd();
            A.ShowDialog();
            refresh();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frm_PeopleMgmt.id = dgv_People.CurrentRow.Cells[0].Value.ToString();
            frm_PeopleMgmt.e_name = dgv_People.CurrentRow.Cells[1].Value.ToString();
            frm_PeopleMgmt.sex = dgv_People.CurrentRow.Cells[2].Value.ToString();
            frm_PeopleMgmt.age = dgv_People.CurrentRow.Cells[3].Value.ToString();
            frm_PeopleMgmt.birthday = dgv_People.CurrentRow.Cells[4].Value.ToString();
            frm_PeopleMgmt.inworkdate = dgv_People.CurrentRow.Cells[5].Value.ToString();
            frm_PeopleMgmt.position = dgv_People.CurrentRow.Cells[6].Value.ToString();
            frm_PeopleMgmt.phone = dgv_People.CurrentRow.Cells[7].Value.ToString();
            frm_PeopleMgmt.address = dgv_People.CurrentRow.Cells[8].Value.ToString();
            frm_PeopleEdit E = new frm_PeopleEdit();
            E.ShowDialog();
            refresh();
        }
        private void refresh()
        {   //重载表
            string strSql;
            DataConnector data = new DataConnector();
            DataSet ds;
            strSql = "SELECT * FROM Employee";
            data.dataCon();
            ds = data.getDataset(strSql);
            dgv_People.DataSource = ds.Tables[0];
        }

        private void btn_Add_MouseEnter(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (a.Enabled)
            {
                switch (a.Text)
                {
                    case "添加(&A)":
                        hintBox.Text = "添加一条记录,完成后将刷新表.";
                        break;
                    case "修改(&E)":
                        hintBox.Text = "修改选中的记录,完成后将刷新表.";
                        break;
                    case "删除(&D)":
                        hintBox.Text = "删除选中的记录,完成后将刷新表.";
                        break;
                }
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_PeopleSearch S = new frm_PeopleSearch();
            S.ShowDialog();
        }
        public static void ExecSQL()
        {
            DataConnector data = new DataConnector();
            DataSet ds;
            data.dataCon();
            ds = data.getDataset(frm_PeopleSearch.strSql);
            dgv_People.DataSource = ds.Tables[0];
        }
    }
}
