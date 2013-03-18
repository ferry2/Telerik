using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentaPrinciples_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle trig = new Triangle(5, 3);
            Rectangle rect = new Rectangle(6, 7);
            Circle circ = new Circle(5);

            object[] obj = new object[3];
            obj[0] = trig;
            obj[1] = rect;
            obj[2] = circ;

            foreach (Shape shape in obj)
            {
                Console.WriteLine("{0} area is: {1}", shape.GetType().Name, shape.CalculateSurface());
            }
            
        }
    }
}
