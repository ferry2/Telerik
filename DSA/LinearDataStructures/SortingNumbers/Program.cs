using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of integers.");
            string sequence = Console.ReadLine();
            string[] integers = sequence.Split(' ');

            var intList = integers.Select(integer => int.Parse(integer)).ToList();

            intList.Sort();

            foreach (var i in intList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
