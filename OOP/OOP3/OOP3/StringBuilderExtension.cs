using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public static class StringBuilderExtension
    {
        public static string Substring(this StringBuilder strBuilder, int startIndex, int length)
        {            
            if(startIndex > strBuilder.Length || length > strBuilder.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid start index or lenght!");
            }

            return strBuilder.ToString(startIndex, length);
        }

        //public static
    }
}
