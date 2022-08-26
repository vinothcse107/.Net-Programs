using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTest.Complex;
using ConsoleTest.Program;
using System.Net;
using System.Collections;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using HotelWCFService;

namespace ConsoleTest.Programs;
public class Program
{
      static Stopwatch st = Stopwatch.StartNew();

      public static void Main(string[] args)
      {
            #region Program_Executors

            // Complex_Type_Comparision_Sorting.Complex_Comparing();
            // Delegates.Delegate_ex();
            // ExtensionMethodOfString.Mark();
            // GenConCaller.GetItems();
            // Threads.APIThreader();

            #endregion

            st.Stop();
            Console.WriteLine(st.Elapsed);
      }
}