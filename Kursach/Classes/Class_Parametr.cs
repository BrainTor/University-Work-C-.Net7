using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Classes
{
    internal class Class_Parametr
    {
       public int index;
       public List<int> List;
       public bool isOver = false;
        public Class_Parametr(int index, List<int> param) {
            this.index = index;
            this.List = param;
        }
    }
}
