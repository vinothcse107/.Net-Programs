using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleTest.Programs;
/*
OUTPUT : 
      Welcome MARKUS WILLIAM !
*/
public class ExtensionMethodOfString
{
      public static void Mark() // Main()
      {
            string Name = "Markus William";
            Console.WriteLine(Name.StringExtend());
      }
}
public static class StringExtender
{
      public static string StringExtend(this string ser)
      {

            // Extend Your Logic Here !
            var x = "Welcome " + ser.ToUpper() + " !";
            return x;
      }
}