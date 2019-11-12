using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuInfo
{
    class Student
    {
        private string name = "";
        private int age;
        private string sex="";
        private string id="";
        public string Name
        {
            get { return name; }
            set {
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set {
                if (value >= 0 && value <= 100) { age = value; }
                else { age = 0; }
            }
        }
        public string Sex
        {
            get { return sex; }
            set {
                if (value.Equals("男") || value.Equals("女")) { sex = value; }
                else { sex = "无效"; }
            }
        }
        public string ID
        {
            get { return id; }
            set
            {
                if (value.Length == 10) { id = value; }
                else { id = "无效"; }
            }
        }
        public virtual string show()
        {
            return "你的姓名为:" + Name + "\r\n年龄为:" + Age.ToString()+"\r\n性别为:" + Sex + "\r\n编号为:" + ID.ToString();
        }
    }
}
