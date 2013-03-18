using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        private static readonly Point3D origin;
        public static Point3D Origin
        {
            get { return origin; }
        }

        static Point3D()
        {
            origin.X = 0;
            origin.Y = 0;
            origin.Z = 0;
        }

        public Point3D(double _X, double _Y, double _Z)
            : this()
        {
            this.X = _X;
            this.Y = _Y;
            this.Z = _Z;
        }

        public override string ToString()
        {
            return string.Format("X coordinate: {0} \nY coordinate: {1} \nZ coordinate: {2}", this.X, this.Y, this.Z);
        }
    }
}
