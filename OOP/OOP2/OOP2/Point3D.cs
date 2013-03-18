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

        private static readonly Point3D origin = new Point3D(0, 0, 0);
        public static Point3D Origin
        {
            get { return origin; }
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
            return string.Format("( {0}; {1}; {2} )", this.X, this.Y, this.Z);
        }
    }
}
