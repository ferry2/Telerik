using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("Pesho");
            Console.WriteLine(str.Substring(1, 3));

            int[] num = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum is: {0}", num.Sum<int>());
            Console.WriteLine("Product is: {0}", num.Product<int>());
            Console.WriteLine("Minimal element is: {0}", num.Min<int>());
            Console.WriteLine("Maximal element is: {0}", num.Max<int>());
            Console.WriteLine("Average sum of elements is: {0}", num.Average<int>());
            Console.WriteLine();

            SortingStudents[] students = 
            { 
                new SortingStudents { FirstName = "Vladislav", LastName = "Naydenov", Age = 29 }, 
                new SortingStudents { FirstName = "Galina", LastName = "Avramska", Age = 27 },
                new SortingStudents { FirstName = "Petar", LastName = "Petrov", Age = 20 },
                new SortingStudents { FirstName = "Kancho", LastName = "Kanchev", Age = 23 },
                new SortingStudents { FirstName = "Jonka", LastName = "Taskova", Age = 19 },
                new SortingStudents { FirstName = "Slavina", LastName = "Naydenova", Age = 24 }
            };

            SortingStudents sort = new SortingStudents();
            sort.Sort(students);

            Console.WriteLine();

            var year = from ages in students
                       where (ages.Age > 18 && ages.Age < 24)
                       select ages;

            foreach(var name in year)
            {
                Console.WriteLine("Fisrt name: {0}, last name: {1}, age: {2}", name.FirstName, name.LastName, name.Age);
            }
            Console.WriteLine();

            // Problem 5, solution with OrderBy() and ThenBy()
            var sortNames = students.OrderByDescending(name => name.FirstName).ThenByDescending(name => name.LastName);

            Console.WriteLine("Solution of 5 with OrderBy and GroupBy");
            foreach(var name in sortNames)
            {
                Console.WriteLine("First name: {0}, last name: {1}", name.FirstName, name.LastName);
            }
            Console.WriteLine();

            //Problem 5, solution with LINQ
            var sortNames2 = from names in students
                             orderby names.FirstName descending
                             select names;

            Console.WriteLine("Solution of 5 with LINQ");
            foreach(var name in sortNames2)
            {
                Console.WriteLine("First name: {0}, last name: {1}", name.FirstName, name.LastName);
            }
            Console.WriteLine();


            //Problem 6
            int[] numbers = { 3, 21, 78, 33, 210, 49, 32, 47, 589, 35, 63, 444, 121, 140 };

            Console.WriteLine("Solution with lambda expression");
            var divisible = numbers.Where(number => number % 7 == 0 && number % 3 == 0).Select(number => number);

            foreach(var number in divisible)
            {
                Console.WriteLine("The numbers divisible by 7 and 3 are: {0}", number);
            }
            Console.WriteLine();

            Console.WriteLine("Solution with LINQ");
            var divisible2 = from integer in numbers
                             where (integer % 7 == 0 && integer % 3 == 0)
                             select integer;

            foreach(var number in divisible2)
            {
                Console.WriteLine("The numbers divisible by 7 and 3 are: {0}", number);
            }
            Console.WriteLine();

            // Class Timer test

            TickDelegate ticks = TimerTick;

            Timer timer = new Timer(100, 5);                        
            Thread timerThread = timer.Start();

            for (int i = 0; i <= 10; i++)
            {
                if (i > 5)
                {
                    Console.WriteLine("Timer Stoped! " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    Console.WriteLine("Timer is Active! " + DateTime.Now.ToLongTimeString());
                }

                if (i == 5)
                {
                    Console.WriteLine("Stopping the timer...");
                    timer.Stop();
                }

                Thread.Sleep(1000);
            }
        } 
        
        public static void TimerTick()
        {
            Console.WriteLine("Timer Ticked!");
        }
    }
}
