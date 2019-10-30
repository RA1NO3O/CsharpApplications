using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oct15th
{
    public partial class Form1 : Form
    {
        Double x;        //单击运算符按钮后暂存用的变量
        int y=0;  
        int calcmode = 0;
        Double memory;
                public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始运行时，输入框的内容为0.
            textBox1.Text = "0";
            textBox2.Text = "";
        }

        private void numbtn_Click(object sender, EventArgs e)
        {   //此方法绑定数字和小数点按钮的单击事件
            if (y==2) { textBox1.Text=""; y = 2; } //如果单击过运算符号/等号/归零按钮，就会在下一次输入将清空输入框的内容
            if (y==0) { textBox1.Text = ""  ;   textBox2.Text = "0" ;    y = 1; }    //如果计算器刚打开，则清空后再进行添加
            Button numBtn = (Button)sender;
            textBox1.Text += numBtn.Text;
            textBox2.Text += numBtn.Text;
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {   //归零按钮
            x = 0;  y = 0;   calcmode = 0;  textBox2.Text = "";
            textBox1.Text = "0";
        }

        private void calcMode_Click(object sender, EventArgs e)
        {   //此方法绑定了四个运算符号按钮的单击事件
            Button calcBtn = (Button)sender;
            if (y == 1)
            {   //如果是第一次运算，直接赋值并暂存运算模式
                y = 2; x = Convert.ToDouble(textBox1.Text); textBox2.Text += calcBtn.Text;
                switch (calcBtn.Text)
                {
                    case "+": calcmode = 1; break;
                    case "-": calcmode = 2; break;
                    case "*": calcmode = 3; break;
                    case "/": calcmode = 4; break;
                }
            }
            else if (y == 2)
            {   //如果不是第一次运算，则先计算先前的表达式
                switch (calcmode)
                {   //判断当前运算模式
                    case 1:
                        if (textBox1.Text == "") { textBox1.Text = Convert.ToString(x + x); }
                        else { x+=Convert.ToDouble(textBox1.Text); }
                        break;
                    case 2:
                        if (textBox1.Text == "") { textBox1.Text = Convert.ToString(x - x); }
                        else { x -= Convert.ToDouble(textBox1.Text); }
                        break;
                    case 3:
                        if (textBox1.Text == "") { textBox1.Text = Convert.ToString(x * x); }
                        else { x *= Convert.ToDouble(textBox1.Text); }
                        break;
                    case 4:
                        if (textBox1.Text == "0") { textBox1.Text = "ERROR"; }
                        else if (textBox1.Text == "") { textBox1.Text = Convert.ToString(x / x); }
                        else { x /= Convert.ToDouble(textBox1.Text); }
                        break;
                }
                textBox1.Text = Convert.ToString(x); textBox2.Text += calcBtn.Text;
                //计算完成后，再将结果显示出来并暂存运算模式
                switch (calcBtn.Text)
                {
                    case "+": calcmode = 1; break;
                    case "-": calcmode = 2; break;
                    case "*": calcmode = 3; break;
                    case "/": calcmode = 4; break;
                }
            }
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {   //等号按钮
            switch (calcmode)
            {   //判断当前运算模式
                case 1:
                    if (textBox1.Text == "") { textBox1.Text = Convert.ToString(x + x); }
                    else { x += Convert.ToDouble(textBox1.Text); }
                    break;
                case 2:
                    if (textBox1.Text == "") { textBox1.Text = Convert.ToString(x - x); }
                    else { x -= Convert.ToDouble(textBox1.Text); }
                    break;
                case 3:
                    if (textBox1.Text == "") { textBox1.Text = Convert.ToString(x * x); }
                    else { x *= Convert.ToDouble(textBox1.Text); } 
                    break;
                case 4:
                    if (textBox1.Text == "0") { textBox1.Text = "ERROR"; }
                    else if (textBox1.Text == "") { textBox1.Text = Convert.ToString(x / x); }
                    else { x /= Convert.ToDouble(textBox1.Text); }
                    break;
            }
            textBox1.Text = Convert.ToString(x); x = 0;  y = 0;   //计算结束后，清空x，下一次输入的值将作为第一个数
        }

        private void MCBtn_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void MRBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(memory);
        }

        private void MSBtn_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(textBox1.Text);
        }

        private void MPlusBtn_Click(object sender, EventArgs e)
        {
            memory +=Convert.ToDouble(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            textBox2.Text = textBox2.Text.Substring(0, textBox2.TextLength - 1);
        }
    }
}
