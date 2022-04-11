using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTest
{
      public static class StringExtender
      {
            public static string StringExtend(this string ser)
            {
                  var x = "Welcome " + ser.ToUpper() + " !";
                  return x;
            }
      }
}