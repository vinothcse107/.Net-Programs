using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTest.Programs;

public class Program
{
      public static void Main()
      {
            Stopwatch st = new Stopwatch();
            st.Start();
            // *****

            // Employee Data In List
            Employee[] ex = {
                  new Employee() { Id = 120, Name = "Vinoth", Experience = 5 },
                  new Employee() { Id = 121, Name = "Sivakumar", Experience = 9 },
                  new Employee() { Id = 122, Name = "Vanitha", Experience = 4 },
                  new Employee() { Id = 123, Name = "Vignesh", Experience = 7 },
                  new Employee() { Id = 124, Name = "Pravin", Experience = 6 },
                  new Employee() { Id = 125, Name = "Keerthi", Experience = 2 }
            };
            var l = new List<Employee>();
            l.AddRange(ex);


            // *****

            st.Stop();
            Console.WriteLine(st.Elapsed);
      }
}

// IComparable - To override The Dafault Comparing Method for Complex Object Comparision
// IEquatable - overrides Equals Method for Complex Object Equality
// IComparer - To override for manual sorting when base class is Not Extendable

public class Employee
{
      public int Id { set; get; }
      public string? Name { set; get; }
      public int Experience { set; get; }
}