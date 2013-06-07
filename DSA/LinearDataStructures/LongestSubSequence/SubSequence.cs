using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubSequence
{
    public class SubSequence
    {
        static void Main(string[] args)
        {
            var list = ReadIntegers();
            var result = FindLongestSubsequence(list);
            Print(result);
        }

        public static List<int> ReadIntegers()
        {
            int n;
            string empty;

            List<int> numbers = new List<int>();

            do
            {
                Console.WriteLine("Enter numbers: ");
                empty = Console.ReadLine();

                if (int.TryParse(empty, out n))
                {
                    numbers.Add(n);
                }

            } while (empty != string.Empty);

            return numbers;
        }

        public static List<int> FindLongestSubsequence(List<int> sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentException("List is null.");
            }

            if (sequence.Count == 0)
            {
                throw new ArgumentException("The list does not contain elements.");
            }            

            int number = 0;
            int sumMax = 1;
            int equalsMax = 0;

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    sumMax += 1;
                }
                else
                {
                    equalsMax = 1;
                }
                
                if (sumMax > equalsMax)
                {
                    equalsMax = sumMax;
                    number = sequence[i];
                }
            }

            List<int> resultList = new List<int>(equalsMax);
            for (int i = 0; i < equalsMax; i++)
            {
                resultList.Add(number);
            }

            return resultList;
        }

        public static void Print(List<int> list)
        {
            Console.WriteLine(string.Join(",", list));          
        }
    }
}
