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
    public partial class frmAddScore : Form
    {
        public frmAddScore()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "insert into Scoreinfo(Sid,Cid,Score) values ('" + txtSid.Text + "','" + txtCid.Text + "','" + txtScore.Text + ",)";
            data.dataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("添加成功!!");
            }
            else
            {
                MessageBox.Show("添加失败!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
