using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HobbySelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hobbychk_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (textBox1.Text.Contains(chk.Text)) { textBox1.Text.Replace(chk.Text, ""); } 
            else { textBox1.Text += chk.Text; }
        }
    }
}
