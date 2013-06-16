using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Efficiency
{
    class Sorting
    {
        static void Main(string[] args)
        {
            List<string[]> data = Read();

            SortedDictionary<string, OrderedBag<Student>> cources = new SortedDictionary<string, OrderedBag<Student>>();

            foreach (var student in data)
            {
                Student st = new Student(student[0], student[1]);
                string key = student[2];

                if (cources.ContainsKey(key))
                {
                    cources[key].Add(st);
                }
                else
                {
                    cources[key] = new OrderedBag<Student>
                        {
                            new Student(student[0], student[1])
                        };
                }
            }

            foreach (var student in cources)
            {
                Console.WriteLine(string.Format("{0} : {1}", student.Key, string.Join(", ", student.Value)));
            }
        }

        public static List<string[]> Read()
        {
            List<string[]> students = new List<string[]>();

            string path = "../../students.txt";
            string[] lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var student = line.Split(new char[] {'|', ' '}, StringSplitOptions.RemoveEmptyEntries);
                students.Add(student);
            }

            return students;
        }
    }
}
