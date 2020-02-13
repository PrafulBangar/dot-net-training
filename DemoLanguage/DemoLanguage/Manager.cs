using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    sealed class Manager:Employee
    {
        public int DA { get; set; }
        public int HRA { get; set; }
        public string Display() { 
        string oline=string.Format("{0},{1},{2},{3},{4},{5}",Empno,Name,Salary,Dept,DA,HRA,CalcSalary());
        return oline;
        
        }

        public override int CalcSalary()
        {
            return Salary + DA + HRA ;
        }
    }
}
