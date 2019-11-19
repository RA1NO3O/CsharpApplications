using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nov19th
{
    public partial class Test3 : Form
    {
        public Test3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single a, b, c;
            a = Convert.ToSingle(textBox1.Text);
            b = Convert.ToSingle(textBox2.Text);
            c = Convert.ToSingle(textBox3.Text);
            Single s = (a + b + c) / 2;
            textBox4.Text = Convert.ToString(Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
        }
    }
}
