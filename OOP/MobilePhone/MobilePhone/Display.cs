using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Display
    {
        private double size = 0;
        public double Size
        {
            get { return this.size; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Моля въведете валидна стойност!");
                }
                this.size = value; 
            }
        }

        private double numberOfColors = 0;
        public double NumberOfColors
        {
            get { return this.numberOfColors; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Моля въведете валидна стойност!");
                }
                this.numberOfColors = value; 
            }
        }

        public Display()
        {            
        }

        public Display(double _size, double _numberOfColors)
        {
            this.size = _size;
            this.numberOfColors = _numberOfColors;
        }
    }
}
