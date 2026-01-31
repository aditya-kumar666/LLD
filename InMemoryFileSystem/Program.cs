using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryFileSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Initialize filesystem with 1 MB capacity
            FileSystemManager fs = new FileSystemManager(1024 * 1024);

            Console.WriteLine("Available Memory: " + fs.GetAvailableMemory());

            // Create files at root
            fs.CreateFile("/", "file1.txt", 200);
            fs.CreateFile("/", "data.log", 300);

            Console.WriteLine("\nRoot Folder:");
            foreach (var item in fs.ListFolder("/"))
            {
                Console.WriteLine(item);
            }

            // Search
            Console.WriteLine("\nSearch 'file':");
            foreach (var result in fs.Search("file"))
            {
                Console.WriteLine(result);
            }

            // Delete file
            fs.DeleteFile("/", "file1.txt");

            Console.WriteLine("\nAfter deletion:");
            foreach (var item in fs.ListFolder("/"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAvailable Memory: " + fs.GetAvailableMemory());
        }
    
    }
}
