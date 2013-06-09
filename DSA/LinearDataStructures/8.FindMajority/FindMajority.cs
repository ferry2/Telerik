using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FindMajority
{
    class FindMajority
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 2, 3, 2, 3, 4, 3, 3 };

            int? majorityElement = null;
            int stack = 0;

            foreach (int n in numbers)
            {
                if (stack == 0) majorityElement = n;
                stack += (n == majorityElement) ? 1 : -1;
            }

            int count = numbers.Count(n => n == majorityElement);
            if (!(count > (numbers.Length / 2)))
                majorityElement = null;

            Console.WriteLine(majorityElement);
        }
    }
}
