using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RemoveOddOccuring
{
    public class RemoveOddOccuring
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine("Enter number: ");
            string number = string.Empty;

            List<int> oddOccurence = new List<int>();

            do
            {
                number = Console.ReadLine();

                if (number != string.Empty)
                {
                    list.Add(int.Parse(number));
                }
            } while (number != string.Empty);

            foreach (int t in list)
            {
                int current = t;

                int count = list.FindAll(n => n == current).Count;

                if (count % 2 == 0)
                {
                    oddOccurence.Add(current);
                }
            }

            oddOccurence.Sort();
            Console.WriteLine(string.Join(",", oddOccurence));
        }
    }
}
