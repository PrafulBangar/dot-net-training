
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
   static class MyFunctions
    {
       public static  int myCount(this string msg) {
           return msg.Split(' ').Count();
          
       }
       public static int StockValue(this Products prod)
       {
           return prod.Stock * prod.Rate;
       }

    }
}
