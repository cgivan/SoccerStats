using System;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirctory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirctory);
            var files = directory.GetFiles("*.txt");
            foreach(var file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.ReadLine();
        }
    }
}
