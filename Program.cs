using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTest.Programs;

public class Program
{
      public static void Main()
      {

            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { Id = 220, Name = "sivakumar", Experience = 8 });
            emplist.Add(new Employee() { Id = 120, Name = "Aravind", Experience = 6 });
            emplist.Add(new Employee() { Id = 150, Name = "jagadeesh", Experience = 10 });
            emplist.Add(new Employee() { Id = 175, Name = "subbalakshmi", Experience = 9 });

            foreach (var x in emplist)
            {
                  Console.WriteLine("{0} {1}", x.Id, x.Name);
            }
      }
}

class Employee
{
      public int Id { set; get; }
      public string? Name { set; get; }
      public int Experience { set; get; }
}




