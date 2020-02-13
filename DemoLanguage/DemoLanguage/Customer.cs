using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class Customer:IAddress,IComparable
    {
        public string PrintAddress()
        {
            throw new NotImplementedException();
      
        }


        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
