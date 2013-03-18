using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OOP2
{
    [Version(3,1)]
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
            numbers.Add(46);
            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(2);
            numbers.Add(8);
            numbers[3] = 5;
            //numbers.InsertAt(7, 6);
            
            //numbers.Clear();
            Console.WriteLine(numbers);
            Console.WriteLine(numbers.Max<int>());
            Console.WriteLine(numbers.Min<int>());

            int[,] matrix1 = new int[3, 3]
            {
                {1, -2, 5},
                {5, 7, 2},
                {7, 1, 3}
            };

            int[,] matrix2 = new int[3, 3]
            {
                {6, -1, 1},
                {9, 1, 8},
                {2, 4, 7}
            };

            Matrix<int> M1 = new Matrix<int>(matrix1);
            Matrix<int> M2 = new Matrix<int>(matrix2);

            Console.WriteLine(M1 + M2);
            Console.WriteLine(M1 - M2);
            Console.WriteLine(M1 * M2);

            Type type = typeof(Program);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach(VersionAttribute version in allAttributes)
            {
                Console.WriteLine("The version is {0}.{1}", version.major, version.minor);
            }
        }
    }
}
