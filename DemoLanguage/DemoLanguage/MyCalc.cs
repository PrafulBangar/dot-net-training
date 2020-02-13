using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class MyCalc:InterfaceA,InterfaceB
    {

        public int add(int x, int y)
        {
           return x + y;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public int subs(int x, int y)
        {
            return x - y;
        }
    }
}
