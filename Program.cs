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
      private static HttpClient _client = new HttpClient();
      private static int _count = 0;
      public static async Task Main(string[] args)
      {
          #region Program_Executors

          // Complex_Type_Comparision_Sorting.Complex_Comparing();
          // Delegates.Delegate_ex();
          // ExtensionMethodOfString.Mark();
          // GenConCaller.GetItems();
          // Threads.APIThreader();
          // await Task.Run(() => TasksEx.FindFile());

          #endregion
          Console.ReadKey();

      }
}