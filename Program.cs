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
      public static void Main(string[] args)
      {
            Stopwatch st = new Stopwatch();
            st.Start();
            #region Program_Executors
            
            // Complex_Type_Comparision_Sorting.Complex_Comparing();
            // Delegates.Delegate_ex();
            // ExtensionMethodOfString.Mark();
            // GenConCaller.GetItems();

            #endregion
            
            // Thread t1 = new Thread(Complex_Type_Comparision_Sorting.Complex_Comparing) { Name = "Thread1" }; 
            // Thread t2 = new Thread(Delegates.Delegate_ex) { Name = "Thread2" };
            //
            // t1.Start();
            // t2.Start();
            
            st.Stop();
            Console.WriteLine(st.Elapsed);
      }
}