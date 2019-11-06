using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SexSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sexrbtn_CheckedChanged(object sender, EventArgs e)
        {
            //多个同类控件绑定同一个触发事件方法,创建控件类型的对象并绑定sender触发对象
            RadioButton rbtn = (RadioButton)sender;
            textBox1.Text = rbtn.Text;
        }
    }
}
