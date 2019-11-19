using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov19th
{
    class CMaster:CStudent
    {
           public string stuMasterName;
           public string StuMasterName
           {
                get
                {
                    return stuMasterName;
                }
                set
                {
                    if(value.Length<2){stuMasterName="#ERROR";}
                    else{stuMasterName=value;}
                }
           }
    }
}
