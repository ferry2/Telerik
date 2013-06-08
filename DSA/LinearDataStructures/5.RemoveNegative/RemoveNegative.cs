using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RemoveNegative
{
    public class RemoveNegative
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter numbers: ");
            string number = null;
          
            do
            {
                number = Console.ReadLine();

                if (number != string.Empty)
                {
                    list.Add(int.Parse(number));    
                }                
            } while (number != string.Empty);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                }
            }

            Console.WriteLine(string.Join(",", list));
        }
    }
}
