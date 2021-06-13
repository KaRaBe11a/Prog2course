using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProg.Classes
{
    class Purchased<T>
    {
        public T Name;
        public int Count;

        public Purchased(T N, int C)
        {
            this.Name = N;
            this.Count = C;
        }

        public string MakeString()
        {
            return Name.ToString() + " " + Count.ToString();
        }
    }
}
