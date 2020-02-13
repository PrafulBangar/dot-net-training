using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DemoLanguage
{
    class MyException:Exception
    {
        public MyException(string msg):base(msg)
        {
            string oline = string.Format("Error================>>{0} occured on {1}",msg,DateTime.Now);
            StreamWriter sw = new StreamWriter("error.txt", true);
            sw.WriteLine(oline);
            sw.Close();
        }
    
    }
}
