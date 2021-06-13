using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProg.Classes
{
    class CompInv<T> : IComparer<T>
        where T : Classes.Purchased<string>
        
    {
        public int Compare(T x, T y)
        {
            if (x.Count < y.Count)
                return 1;
            if (x.Count > y.Count)
                return -1;
            else
                return 0;
        }
    }
}
