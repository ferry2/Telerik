using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIctionaryHashTableSet
{
    class FindOccurences
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine("Enter number: ");
            string number = string.Empty;

            do
            {
                number = Console.ReadLine();

                if (number != string.Empty)
                {
                    list.Add(int.Parse(number));
                }
            } while (number != string.Empty);

            Dictionary<int, int> occurences = new Dictionary<int, int>();
            int count = 0;

            foreach (var item in list)
            {
                if (!occurences.TryGetValue(item, out count))
                {
                    occurences.Add(item, 1);
                }
                else
                {
                    occurences[item]++;
                }
            }

            foreach (var key in occurences)
            {
                Console.WriteLine("{0} -> {1}", key.Key, key.Value);
            }
        }
    }
}
