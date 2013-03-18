using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Vladislav", "Naydenov", 10));
            students.Add(new Student("Galina", "Naydenova", 7));
            students.Add(new Student("Slavina", "Naydenova", 1));
            students.Add(new Student("Kancho", "Kanchev", 12));
            students.Add(new Student("Jonka", "Taskova", 11));
            students.Add(new Student("Petar", "Petrov", 5));
            students.Add(new Student("Ivan", "Dimitrov", 8));
            students.Add(new Student("Stojko", "Avramski", 2));
            students.Add(new Student("Vanq", "Marincheshka", 9));
            students.Add(new Student("Georgi", "Naydenov", 10));

            var sortedStudents = from stud in students
                                 orderby stud.Grade ascending
                                 select stud;

            foreach(Student student in sortedStudents)
            {
                Console.WriteLine("Name: {0} {1}, grade: {2}", student.FirstName, student.LastName, student.Grade);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Bogdanov", 100, 8));
            workers.Add(new Worker("Petar", "Kanchev", 150, 8));
            workers.Add(new Worker("Silvia", "Kirkova", 175, 9));
            workers.Add(new Worker("Velislava", "Vasileva", 80, 4));
            workers.Add(new Worker("Atanas", "Bqlin", 115, 8));
            workers.Add(new Worker("Marinela", "Shishmanova", 128, 8));
            workers.Add(new Worker("Katq", "Shateva", 144, 6));
            workers.Add(new Worker("Svetlozar", "Parapanov", 254, 10));
            workers.Add(new Worker("Ivanka", "Halembakova", 98, 8));
            workers.Add(new Worker("Stefka", "Georgieva", 301, 12));

            var sortedWorkers = from worker in workers
                               orderby worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay) descending
                               select worker;

            foreach(Worker worker in sortedWorkers)
            {
                Console.WriteLine("Name: {0} {1}, money per hour: {2:C}", worker.FirstName, worker.LastName, worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay));
            }
            Console.WriteLine();

            var merge = new List<Human>(students.Count + workers.Count);
            merge.AddRange(students);
            merge.AddRange(workers);

            var sortLists = merge.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach(Human human in sortLists)
            {
                Console.WriteLine("Name: {0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
