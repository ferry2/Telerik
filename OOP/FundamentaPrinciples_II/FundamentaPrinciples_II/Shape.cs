using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentaPrinciples_II
{
    /// <summary>
    /// Define abstract Shape. 
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Width of the shape.
        /// </summary>
        private double width;

        

        /// <summary>
        /// Height of the shape.
        /// </summary>
        private double height;        

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape" /> class and set width and height of the shape.
        /// </summary>
        /// <param name="height">Height of the Shape.</param>
        /// <param name="width">Width of the Shape.</param>
        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape" /> class.
        /// </summary>
        public Shape()
        {            
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        /// <summary>
        /// Abstract method for calculating area of the shape.
        /// </summary>
        /// <returns>Area of the shape.</returns>
        public abstract double CalculateSurface();        
    }
}
