using System.Diagnostics;

namespace ConsoleTest.Programs;

public static class TasksEx
{
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
                await DirFinder(path, dirName);
                break;
            }
            
            case "2" :
            {
                Console.WriteLine("File Name :");
                string fileName = Console.ReadLine();
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
                if (s.Name.StartsWith(find))
                    Console.WriteLine($"{s.FullName}");
            

            foreach (var v in d.GetDirectories())
                await Task.Run(() =>
                {
                    FileFinder(v.FullName, find);
                });
        }
        catch (UnauthorizedAccessException) {}
    }
    
    public static async Task DirFinder(string path, string find)
    {
        try
        {
            DirectoryInfo d = new DirectoryInfo(path);

            var dirs = d.GetDirectories();
            if (dirs.Any((f) => f.Name.StartsWith(find)))
            {
                Console.WriteLine(d.FullName);
            }
            else
            {
                foreach (var v in dirs)
                {
                    await Task.Run(() =>
                    {
                        DirFinder(v.FullName, find);
                    });
                }
            }
        }
        catch (UnauthorizedAccessException) {}
    }
}