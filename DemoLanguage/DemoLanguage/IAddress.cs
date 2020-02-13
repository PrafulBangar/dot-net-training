using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    interface IAddress
    {
        string PrintAddress();

    }

    interface InterfaceA {
        int add(int x, int y);
        int multiply(int x, int y);
    }

    interface InterfaceB {
        int add(int x, int y);
        int subs(int x, int y);

    }

 }
