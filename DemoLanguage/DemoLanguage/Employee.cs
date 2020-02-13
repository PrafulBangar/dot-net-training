using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
   abstract class Employee
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Dept { get; set; }
        public abstract int CalcSalary();

        public string Display() { 
        string oline=string.Format("{0},{1},{2},{3}",Empno,Name,Salary,Dept);
            return oline;
        }

    }
}
