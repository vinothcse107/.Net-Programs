using System;
using System.Linq;
using System.Collections.Generic;
using ConsoleTest;

public class ExtensionMethodOfString
{
      public static void Main()
      {
            string Name = "Markus William";
            Console.WriteLine(Name.StringExtend());
      }
}
public static class StringExtender
{
      public static string StringExtend(this string ser)
      {
            var x = "Welcome " + ser.ToUpper() + " !";
            return x;
      }
}