using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public static class CalculateDistance
    {               
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) + (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) + (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));
        }
    }
}
