// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ConsoleTest.Programs;

// /*
// OUTPUT :

// Employee sivakumar Promoted
// Employee jagadeesh Promoted
// Employee subbalakshmi Promoted
// */
// public class Delegates
// {
//       public static void Main() // Main()
//       {

//             List<Employee> emplist = new List<Employee>();

//             emplist.Add(new Employee() { Id = 220, Name = "sivakumar", Experience = 8 });
//             emplist.Add(new Employee() { Id = 120, Name = "Aravind", Experience = 6 });
//             emplist.Add(new Employee() { Id = 150, Name = "jagadeesh", Experience = 10 });
//             emplist.Add(new Employee() { Id = 175, Name = "subbalakshmi", Experience = 9 });


//             // Method 1

//             static bool EligibleEmp(Employee ee)
//             {
//                   if (ee.Id >= 130) return true;
//                   else return false;
//             }

//             Employee.PromoteEmployee(emplist, EligibleEmp);

//             //Method 2

//             Employee.PromoteEmployee(emplist, x => x.Id > 125);

//             // Method 3


//             var x = (Employee y) => y.Id > 125;
//             Employee.Lambda_Optimized(emplist, x);


//       }
// }
// delegate bool IsPromotable(Employee emp1);

// class Employee
// {
//       public int Id { set; get; }
//       public string? Name { set; get; }
//       public int Experience { set; get; }

//       public static void PromoteEmployee(List<Employee> emp, IsPromotable del)
//       {
//             foreach (Employee employee in emp)
//             {
//                   if (del(employee))
//                   {
//                         Console.WriteLine("Employee" + " " + employee.Name + " " + "Promoted");
//                   }
//             }
//       }

//       public static void Lambda_Optimized(List<Employee> emp, Func<Employee, bool> del)
//       {
//             foreach (Employee employee in emp)
//             {
//                   if (del(employee))
//                   {
//                         Console.WriteLine("Employee" + " " + employee.Name + " " + "Promoted");
//                   }
//             }
//       }
// }




