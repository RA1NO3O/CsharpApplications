using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Teacher student1 = new Teacher();
            student1.Name = txtName.Text;
            student1.Age = int.Parse(txtAge.Text);
            student1.Sex = txtSex.Text;
            student1.ID = txtID.Text;
            student1.Tname = txtTname.Text;
            MessageBox.Show(student1.show(),"",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
