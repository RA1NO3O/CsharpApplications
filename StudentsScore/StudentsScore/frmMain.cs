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
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void tsmiStudentAdd_Click(object sender, EventArgs e)
        {
            frmAddStu AddStu = new frmAddStu();
            AddStu.MdiParent = this;
            AddStu.Show();
        }
        private void tsmiStudentUpdate_Click(object sender, EventArgs e)
        {
            frmManageStu ManageStu = new frmManageStu();
            ManageStu.MdiParent = this;
            ManageStu.Show();
        }
        private void tsmiStudentSearch_Click(object sender, EventArgs e)
        {
            frmManageStu ManageStu = new frmManageStu();
            ManageStu.MdiParent = this;
            ManageStu.Show();
        }
        private void tsmiStudentDelete_Click(object sender, EventArgs e)
        {
            frmManageStu ManageStu = new frmManageStu();
            ManageStu.MdiParent = this;
            ManageStu.Show();
        }
        private void tsmiCourseSearch_Click(object sender, EventArgs e)
        {
            frmManageCourse ManageCourse = new frmManageCourse();
            ManageCourse.MdiParent = this;
            ManageCourse.Show();
        }
        private void tsmiCourseAdd_Click(object sender, EventArgs e)
        {
            frmAddCourse AddCourse = new frmAddCourse();
            AddCourse.MdiParent = this;
            AddCourse.Show();
        }
        private void tsmiCourseUpdate_Click(object sender , EventArgs e)
        {
            frmManageCourse ManageCourse = new frmManageCourse();
            ManageCourse.MdiParent = this;
            ManageCourse.Show();
        }
        private void tsmiCourseDelete_Click(object sender , EventArgs e)
        {
            frmManageCourse ManageCourse = new frmManageCourse();
            ManageCourse.MdiParent = this;
            ManageCourse.Show();
        }
        private void tsmiScoreSearch_Click(object sender , EventArgs e)
        {
            frmManageScore ManageScore = new frmManageScore();
            ManageScore.MdiParent = this;
            ManageScore.Show();
        }
        private void tsmiScoreAdd_Click(object sender , EventArgs e)
        {
            frmAddScore AddScore = new frmAddScore();
            AddScore.MdiParent = this;
            AddScore.Show();
        }
        private void tsmiScoreUpdate_Click(object sender , EventArgs e)
        {
            frmManageScore ManageScore = new frmManageScore();
            ManageScore.MdiParent = this;
            ManageScore.Show();
        }
        private void tsmiScoreDelete_Click(object sender , EventArgs e)
        {
            frmManageScore ManageScore = new frmManageScore();
            ManageScore.MdiParent = this; ;
            ManageScore.Show();
        }
        private void tsmiVersion_Click(object sender , EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.MdiParent = this;
            About.Show();
        }
        private void tsbtnStudent_Click(object sender , EventArgs e)
        {
            frmManageStu ManageStu = new frmManageStu();
            ManageStu.MdiParent = this;
            ManageStu.Show();
        }
        private void tsbtnCourse_Click(object sender , EventArgs e)
        {
            frmManageCourse ManageCourse = new frmManageCourse();
            ManageCourse.MdiParent = this;
            ManageCourse.Show();
        }
        private void tsbtnScore_Click(object sender , EventArgs e)
        {
            frmManageScore ManageScore = new frmManageScore();
            ManageScore.MdiParent = this;
            ManageScore.Show();
        }
    }
}

