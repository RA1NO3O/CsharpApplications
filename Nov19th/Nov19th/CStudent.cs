using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov19th
{
    class CStudent
    {
        string stuName = "";
        string stuNation = "";
        string stuID = "";
        int stuAge, stuScoreGrade;
        public string StuID
        {
            get
            {
                return stuID;
            }
            set
            {
                if (value.Length != 9) { stuID = "#ERROR"; }
                else { stuID = value; }
            }
        }
        public string StuName
        {
            get
            {
                return stuName;
            }
            set
            {
                if (value.Length < 2) { stuID = "#ERROR"; }
                else { stuName = value; }
            }
        }
        public string StuNation
        {
            get
            {
                return stuNation;
            }
            set
            {
                if (value.Length < 2) { stuNation = "#ERROR"; }
                else { stuNation = value; }
            }
        }
        public int StuAge
        {
            get
            {
                return stuAge;
            }
            set
            {
                if (stuAge < 1 || stuAge > 150) { stuAge = 0; }
                else { stuAge = value; }
            }
        }
        public int StuScoreGrade
        {
            get
            {
                return stuScoreGrade;
            }
            set
            {
                if (value > 100 && value < 1) { stuScoreGrade = 0; }
                else { stuScoreGrade = value; }
            }
        }
    }
}
