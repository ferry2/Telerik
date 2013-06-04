using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1, 4, 5);
            Point3D point2 = new Point3D(2, 4.5, 6);

            Console.WriteLine("The distance between point1 and point2 is: {0}", CalculateDistance.Distance(point1, point2));

            Path path = new Path();
            path.AddPoint(point1);
            path.AddPoint(point2);
            PathStorage.SavePath(path);
            PathStorage.LoadPath();

            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(56);
            //numbers.Add(46);
            //numbers.Add(5);
            //numbers.Add(2);
            //numbers.Add(2);
            //numbers.Add(8);
            //numbers[3] = 5;
            //numbers.InsertAt(7, 6);
            //numbers.Clear();
            Console.WriteLine(numbers);
        }
    }
}
