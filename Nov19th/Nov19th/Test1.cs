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
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();

            comboBox1.Items.Add("隶书");
            comboBox1.Items.Add("宋体");
            comboBox1.Items.Add("宋体 - PUA");
            comboBox1.Items.Add("宋体 - 方正超大字符集");
            comboBox1.Items.Add("微软雅黑");
            comboBox1.Items.Add("新宋体");
            comboBox1.Items.Add("幼圆");
        }
        private void comboBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = e.Bounds;
            Size imageSize = imageList1.ImageSize;
            Font fn = null;
            if (e.Index >= 0)
            {
                fn =new Font("宋体",9);
                string s = (string)comboBox1.Items[e.Index];
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                if (e.State == (DrawItemState.NoAccelerator | DrawItemState.NoFocusRect))
                {
                    //画条目背景 
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), r);
                    //绘制图像 
                    imageList1.Draw(e.Graphics, r.Left, r.Top, e.Index);
                    //显示字符串 
                    e.Graphics.DrawString(s, fn, new SolidBrush(Color.Black), r.Left + imageSize.Width, r.Top);
                    //显示取得焦点时的虚线框 
                    e.DrawFocusRectangle();
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), r);
                    imageList1.Draw(e.Graphics, r.Left, r.Top, e.Index);
                    e.Graphics.DrawString(s, fn, new SolidBrush(Color.Black), r.Left + imageSize.Width, r.Top);
                    e.DrawFocusRectangle();
                }
            }
        }

        private void Onclick(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
