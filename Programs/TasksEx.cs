using System.Diagnostics;
using BenchmarkDotNet.Attributes;

namespace ConsoleTest.Programs;

// [MemoryDiagnoser]
public static class TasksEx
{
    // [Benchmark]

    public static Stopwatch st = new Stopwatch();
    public static async void FindFile()
    {
        string path = "C:/";

        Console.WriteLine("1. Search Directory\n2. Search File");
        string x = Console.ReadLine();
        switch(x)
        {
            case "1" :
            {
                Console.WriteLine("Folder Name :");
                string dirName = Console.ReadLine();
                st.Start();
                await DirFinder(path, dirName);
                break;
            }
            
            case "2" :
            {
                Console.WriteLine("File Name :");
                string fileName = Console.ReadLine();
                st.Start();
                await FileFinder(path, fileName);
                break;
            }
                    
            default :
            {
                Console.WriteLine("Invalid Option !!!");
                break;
            }
        };
    }

    public static async Task FileFinder(string path, string find)
    {
        try
        {
            DirectoryInfo d = new DirectoryInfo(path);

            foreach (var s in d.GetFiles())
            {
                if (s.Name.StartsWith(find))
                    Console.WriteLine($"{s.FullName} {st.ElapsedMilliseconds}");
            }
            
            foreach (var v in d.GetDirectories())
            {
                await Task.Run(() => { FileFinder(v.FullName, find); });
            }
        }
        catch (UnauthorizedAccessException) {}
    }
    
    public static async Task DirFinder(string path, string find)
    {
        try
        {
            DirectoryInfo d = new DirectoryInfo(path);
            var dirs = d.EnumerateDirectories();
            
            if (dirs.Any((f) => f.Name.StartsWith(find)))
                Console.WriteLine($"{d.FullName} {st.ElapsedMilliseconds}");
            
            else
                foreach (var v in dirs)
                    await Task.Run(() =>
                    {
                        DirFinder(v.FullName, find);
                    });
        }
        catch (UnauthorizedAccessException) {}
    }
    
    //---------------------------------------------------
    // To Run Multiple Tasks In Parallel                                                                             
    //---------------------------------------------------
    
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
    
}