using System;
using System.IO;

namespace working_with_files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Files🙌🏾!");
            var fullPath = Path.GetFullPath("/Users/oluwasetemi");
            var dirHome = Directory.GetDirectories(fullPath);
            foreach (var dir in dirHome)
                Console.WriteLine(dir);

            var fileHome = Directory.GetFiles(fullPath);
            foreach (var fileHo in fileHome)
                Console.WriteLine(fileHo);

            File.WriteAllText("/Users/oluwasetemi/Projects/created-by-c#.txt", "hello ,world");

            // FileInfo
            // File
            // Directory
            // DirectoryInfo
            // Path
            
        }
    }
}
