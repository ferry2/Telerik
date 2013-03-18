using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentaPrinciples_II
{
    /// <summary>
    /// Model rectangle. It inherit the abstract class Shape.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Rectangle" /> class and set width and height of the rectangle.
        /// </summary>
        /// <param name="_height">Width of the rectangle.</param>
        /// <param name="_width">Height of the rectangle.</param>
        public Rectangle(double _height, double _width)
            : base(_height, _width)
        {
        }

        /// <summary>
        /// Overrriden method for calculating area of rectangle.
        /// </summary>
        /// <returns>Area of the rectangle.</returns>
        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }        
    }
}
