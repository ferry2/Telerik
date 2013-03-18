using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMProgram
{
    public class Display
    {
        private int? height;
        private int? width;
        private int? numberOfColors;
        
        public int? Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot be less than zero");
                }
                this.height = value;
            }
        }

        public int? Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot be less than zero");
                }
                this.width = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot be less than zero");
                }

                this.numberOfColors = value;
            }
        }

        public Display() : this(null,null,null)
        {
        }

        public Display(int height, int width) : this(height, width, null)
        {
        }

        public Display(int? height, int? width, int? numberOfColors)
        {
            this.Height = height;
            this.Width = width;
            this.NumberOfColors = numberOfColors;
        }
    }
}