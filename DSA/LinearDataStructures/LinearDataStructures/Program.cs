using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            var integers = new List<int>();

            for (string empty = null; (empty = Console.ReadLine()) != string.Empty;)
            {
                integers.Add(int.Parse(empty));
            }

            Console.WriteLine("\nThe Sum of the elments is {0} \n", integers.Sum());
            Console.WriteLine("\nThe Average of the elments is {0} \n", integers.Average());
        }
    }
}
