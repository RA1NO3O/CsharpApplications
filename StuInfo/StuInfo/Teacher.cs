using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuInfo
{
    class Teacher:Student
    {
        private string tname = "";
        public string Tname
        {
            get { return tname; }
            set {
                tname = value;
            }
        }
        public override string show()
        {
            return "你的姓名为:" + Name + "\r\n年龄为:" + Age.ToString() + "\r\n性别为:" + Sex + "\r\n编号为:" + ID.ToString() + "\r\n指导教师为:" + Tname;
        }
    }
}
