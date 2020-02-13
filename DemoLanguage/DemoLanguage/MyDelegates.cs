using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class MyDelegates
    {
        public delegate void CalcDelegates(int x, int y);
        public delegate void ToppingDelegate(string name);

        public void MAkePizza(string name, ToppingDelegate td)
        {
            Console.WriteLine("instead go and buy pizza");
            Console.WriteLine("eat pizza");
            td(name);
            Console.WriteLine("pay money");
            Console.WriteLine("Review");
        }

        public void add(int x, int y)
        {
            Console.WriteLine("Add={0}", x + y);
        }
        public void multiply(int x, int y)
        {
            Console.WriteLine("Multiply={0}", x * y);
        }

        public void subtract(int x, int y)
        {
            Console.WriteLine("Difference={0}", x - y);
        }

    }
}
