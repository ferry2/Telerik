using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentaPrinciples_II
{
    /// <summary>
    /// Model triangle. It inherit the abstract class Shape.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class and set width and height of triangle.
        /// </summary>
        /// <param name="height">Height of the triangle.</param>
        /// <param name="width">Width of the triangle.</param>
        public Triangle(double height, double width)
            : base(height, width)
        {            
        }

        /// <summary>
        /// Overridden method for calculating surface of triangle.
        /// </summary>
        /// <returns>Area of the triangle</returns>
        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
