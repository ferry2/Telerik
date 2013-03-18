using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidException
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input integer from range [1,100]: ");
            int p = int.Parse(Console.ReadLine());

            InvalidRangeException<int> invalidInt = new InvalidRangeException<int>("The value is out of the range: [1;100]", 1, 100, p);

            if (p < invalidInt.Start || p > invalidInt.End)
            {
                //throw new InvalidRangeException<int>();
                Console.WriteLine(invalidInt.Message);                
            }
            else
            {
                Console.WriteLine("The value is proper!");
            }            

            string startDate = "01.01.1980";
            string endDate = "31.12.2013";            

            Console.Write("Input date between 01.01.1980 and 31.12.2013: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            InvalidRangeException<DateTime> invalidDate = new InvalidRangeException<DateTime>(
                "The input date is out of defined range: [01.01.1980; 31.12.2013]",
                DateTime.Parse(startDate).Date,
                DateTime.Parse(endDate).Date,
                date.Date);

            if (date < invalidDate.Start || date > invalidDate.End)
            {
                Console.WriteLine(invalidDate.Message);
            }
            else
            {
                Console.WriteLine("The date is correct!");
            }
        }
    }
}
