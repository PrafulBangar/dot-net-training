using System;
using Greetings;

namespace DemoLanguage
{
    class TestDll
    {
        static void Main()
        {
            Greet gt = new Greet();
            Console.WriteLine("{0}", gt.Hello("Tom"));
            Console.WriteLine("{0}", gt.GoodBye());
            Console.ReadLine();
        }
    }
}
