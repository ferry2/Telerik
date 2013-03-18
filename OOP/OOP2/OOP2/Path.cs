using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Path
    {
        private List<Point3D> points = new List<Point3D>();
        public List<Point3D> Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public Path()
        {
            
        }
        
        public void AddPoint(Point3D point)
        {
            points.Add(point);
        }
    }
}
