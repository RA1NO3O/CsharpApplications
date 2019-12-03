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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
            private void frmMain_FormClosing(object sender,FormClosingEventArgs e)
            {
                Application.Exit();
            }
            private void tsmiStudentAdd_Click(object sender,EventArgs e)
            {
                frmAddStu AddStu = new frmAddStu();
                AddStu.MdiParent = this;
                AddStu.Show();
            }
            private void tsmiStudentUpdate_Click(object sender,EventArgs e)
            {
                frmManageStu ManageStu = new frmManageStu();
                ManageStu.MdiParent = this;
                ManageStu.Show();
            }
            private void tsmiStudentSearch_Click(object sender , EventArgs e)
            {
                frmManageStu ManageStu = new frmManageStu();
                ManageStu.MdiParent = this;
                ManageStu.Show();
            }
            private void tsmiStudentDelete_Click(object sender , EventArgs e)
            {
                frmManageStu ManageStu = new frmManageStu();
                ManageStu.MdiParent = this;
                ManageStu.Show();
            }
            
    }
}

