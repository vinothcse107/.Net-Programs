using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleTest.Complex;

public static class Complex_Type_Comparision_Sorting
{
      public static void Complex_Comparing()
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

            // Sorting Complex Type Object Type in List 

            // * Method 1
            // Call overrided Method
            // int Employee.CompareTo(object ? obj)

            Console.WriteLine("Method 1\n");
            l.Sort();
            foreach (var r in l)
            {
                  Console.WriteLine(r);
            }

            // * Method 2
            // Inline Comparision Using Lambda Expression
            // Internally Calling Comparision delegate
            Console.WriteLine("\nMethod 2\n");
            l.Sort((a, b) => a.Name.CompareTo(b.Name));
            foreach (var r in l)
            {
                  Console.WriteLine(r);
            }

            // * Method 3
            // Using Linq Expression Methods
            Console.WriteLine("\nMethod 3\n");

            var w = l.OrderBy(s => s.Name);
            foreach (var r in w)
            {
                  Console.WriteLine(r);
            }

            // * Method 4
            // Using Comparer ( For Classes which are unmuteable)
            Console.WriteLine("\nMethod 4\n");

            comprator c = new comprator();
            l.Sort(c);
            foreach (var r in l)
            {
                  Console.WriteLine(r);
            }
            // Equality Checker for Complex Object Type
            // bool Employee.Equals(Employee ? other)
            Console.WriteLine("\nEquality\n");

            var e1 = new Employee() { Id = 120, Name = "Vinoth", Experience = 5 };
            var e2 = new Employee() { Id = 121, Name = "Sivakumar", Experience = 9 };
            Console.WriteLine(e1.Equals(e2));

            // *****

            st.Stop();
            Console.WriteLine(st.Elapsed);
      }

}


// IComparable - To override The Dafault Comparing Method for Complex Object Comparision
// IEquatable - overrides Equals Method for Complex Object Equality
// IComparer - To override for manual sorting when base class is Not Extendable

public class Employee : IComparable, IEquatable<Employee>
{
      public int Id { set; get; }
      public string Name { set; get; }
      public int Experience { set; get; }

      public override string ToString()
      {
            return $"{Id} {Name} {Experience}";
      }

      public int CompareTo(object obj)
      {
            var e = obj as Employee;

            if (this.Experience < e.Experience)
                  return -1;
            else if (this.Experience > e.Experience)
                  return 1;
            else
                  return 0;
      }

      public bool Equals(Employee other)
      {
            var x = other as Employee;
            return this.Experience.Equals(x.Experience);
      }
}

public class comprator : IComparer<Employee>
{
      public int Compare(Employee x, Employee y)
      {
            return x.Id - y.Id;
      }
}