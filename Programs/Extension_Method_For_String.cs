using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleTest.Programs;
/*
OUTPUT : 
      Welcome MARKUS WILLIAM !
*/
public static class ExtensionMethodOfString
{
      public static void Mark()
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
            var x = $"Welcome {ser.ToUpper()} !";
            return x;
      }
}