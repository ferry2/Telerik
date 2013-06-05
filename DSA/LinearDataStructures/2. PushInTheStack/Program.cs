using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PushInTheStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = new Stack<int>();

            for (string empty = null; (empty = Console.ReadLine()) != string.Empty; )
                integers.Push(int.Parse(empty));

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
