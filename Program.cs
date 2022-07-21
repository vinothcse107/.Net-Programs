using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTest.Complex;
using ConsoleTest.Program;
using System.Net;
using System.Collections;

namespace ConsoleTest.Programs;
public class Program
{
      public record Mast(int fx, string fn)
      {
            public string str()
            {
                  return $"Hello World";
            }
      }

      public static void Main(string[] args)
      {

            // var complex = new Complex_Type_Comparision_Sorting();
            // var delegates = new Delegates();
            // var ExtensionMethod = new ExtensionMethodOfString();
            // Test t = new Test();
            // t.Peas();

      }
}
