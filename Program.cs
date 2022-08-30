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

          #endregion

          await Task.Run(() => TasksEx.FindFile());
          Console.ReadKey();
          // var t = new List<Task>();
          //
          // Task<int> a = Task.Run(() => { Thread.Sleep(3000); Console.WriteLine("Welcome1");
          //     return 1;
          // });
          // Task b = Task.Run(() => { Thread.Sleep(2000); Console.WriteLine("Welcome2");});
          // Task c = Task.Run(() => { Thread.Sleep(1000); Console.WriteLine("Welcome3");});
          // Task d = Task.Run(() => { Thread.Sleep(6000); Console.WriteLine("Welcome4");}); 
          // Task e = Task.Run(() => { Thread.Sleep(5000); Console.WriteLine("Welcome5");});
          // Task f = Task.Run(() => { Thread.Sleep(5000); Console.WriteLine("Welcome6");});
          //
          // t.AddRange(new List<Task>(){a,b,c,d,e,f});
          // await Task.WhenAll(t);
          // Console.WriteLine(a.Result);

          //
          // st.Stop();
          // Console.WriteLine(st.Elapsed);
      }
}