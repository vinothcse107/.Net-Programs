using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTest.Complex;
using ConsoleTest.Program;
using System.Net;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace ConsoleTest.Programs;
public class Program
{


      public static void Main(string[] args)
      {

            // var complex = new Complex_Type_Comparision_Sorting();
            // var delegates = new Delegates();
            // var ExtensionMethod = new ExtensionMethodOfString();
            // Test t = new Test();
            // t.Peas();


            var x = GenericPropAssigner<Items>.DynamicValues();
            Console.WriteLine(x);

      }
}
