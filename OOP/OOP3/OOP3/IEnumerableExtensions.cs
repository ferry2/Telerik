using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> enumerate) where T : struct
        {
            if(enumerate == null)
            {
                throw new ArgumentNullException("The collection must have at least one element.");
            }

            T sum = (dynamic)0;

            foreach(T item in enumerate)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumerate) where T : struct
        {
            if (enumerate == null)
            {
                throw new ArgumentNullException("The collection must have at least one element.");
            }

            T product = (dynamic)1;

            foreach(T item in enumerate)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> enumerate) where T : IComparable<T>
        {
            if (enumerate == null)
            {
                throw new ArgumentNullException("The collection must have at least one element.");
            }

            T min = enumerate.First<T>();

            foreach (T item in enumerate)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> enumerate) where T : IComparable<T>
        {
            if (enumerate == null)
            {
                throw new ArgumentNullException("The collection must have at least one element.");
            }

            T max = enumerate.First<T>();

            foreach (T item in enumerate)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static double Average<T>(this IEnumerable<T> enumerate) where T : struct
        {
            if (enumerate == null)
            {
                throw new ArgumentNullException("The collection must have at least one element.");
            }
    
            return (dynamic)enumerate.Sum<T>() / (dynamic)enumerate.Count<T>();
        }
    }
}
