using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentaPrinciples_II
{
    /// <summary>
    /// Model a Circle.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle" /> class. It set width equals to height.
        /// </summary>
        /// <param name="width">Radius for the circle.</param>
        public Circle(double width) : base(width, width)
        {         
        }

        /// <summary>
        /// Overridden method. Calculate area of circle.
        /// </summary>
        /// <returns>Area of the circle.</returns>
        public override double CalculateSurface()
        {
            return Math.PI * this.Height * this.Height;
        }
    }
}
