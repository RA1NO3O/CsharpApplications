using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov12th
{
    class Student
    {
        private string ID, Name,Sex,Age;
        public string sex {
            get {
                return Sex;
            }
            set
            {
                if (value.Equals("男") || value.Equals("女")) { Sex = value; }
                else { Sex = "无效"; }
            }
        }
         public int age
        {
            get
            {
                return Convert.ToInt32(Age);
            }
            set
            {
                if (value <= 100 && value>=0) { Age = Convert.ToString(value); }
                else { Age = "无效"; }
            }
        }
        public string id
        {
            get
            {
                return ID;
            }
            set
            {
                if (value.Length == 10) { ID = value; }
                else { ID = "无效"; }
            }
        }
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                if (value.) { }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.id = "01";    a.name = "a";   a.sex = "male";     a.age = 18;
            Console.WriteLine("学号是:{0},\r\n姓名是:{1},\r\n性别是:{2},\r\n年龄是:{3},\r\n", a.id,a.name,a.sex,a.age);
            Console.ReadLine();
        }
    }
}
