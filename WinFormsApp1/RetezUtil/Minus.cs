using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetezUtil
{
    public class Minus
    {

        string s;
        public Minus(string s)
        {
            this.s = s;
        }

        static public string operator -(Minus x, Minus y)
        {
            return x.s.Replace(y.s, "");
        }

    }
}
