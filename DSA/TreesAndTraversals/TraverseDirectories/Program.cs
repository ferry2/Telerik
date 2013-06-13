using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ROOT = "C:\\Windows";

            List<string> dirs = new List<string>();
            List<string> exes = new List<string>();

            StringBuilder errors = new StringBuilder();

            Queue<string> rootDirs = new Queue<string>();

            rootDirs.Enqueue(ROOT);

            while (rootDirs.Count > 0)
            {
                var current = rootDirs.Peek();

                try
                {
                    foreach (var dir in Directory.GetDirectories(current))
                    {
                        rootDirs.Enqueue(dir);
                        dirs.Add(dir);
                    }

                    var files = Directory.GetFiles(current, "*.exe");
                    exes.AddRange(files);
                }
                catch (UnauthorizedAccessException ex)
                {
                    errors.AppendLine(ex.Message);
                }

                rootDirs.Dequeue();
            }

            if (errors.Length > 0)
            {
                Console.WriteLine("Errors: ");
                Console.WriteLine(errors);
            }

            Console.WriteLine("Directories tree of C:\\Windows partition: ");
            Print(exes);
        }

        private static void Print(IEnumerable<string> element)
        {
            StringBuilder elements = new StringBuilder();

            foreach (var item in element)
            {
                elements.AppendLine(item);
            }

            Console.WriteLine(elements);
        }
    }
}
