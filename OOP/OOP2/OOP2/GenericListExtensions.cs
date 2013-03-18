using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public static class GenericListExtensions
    {
        public static T Min<T>(this GenericList<T> arrList) where T : IComparable<T>
        {
            if (arrList.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }
            else if (arrList.Count == 1)
            {
                return (T)(object)arrList[0];
            }
            else if (arrList[0] is IComparable<T>)
            {
                T min = (T)(object)arrList[0];

                for (int i = 1; i < arrList.Count; i++)
                {
                    if (min.CompareTo((T)(object)arrList[i]) > 0)
                    {
                        min = (T)(object)arrList[i];
                    }
                }
                return min;
            }
            else
            {
                throw new ArgumentException("The list elements must implement IComparable.");
            }
        }

        public static T Max<T>(this GenericList<T> arrList) where T : IComparable<T>
        {
            if (arrList.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }
            else if (arrList.Count == 1)
            {
                return (T)(object)arrList[0];
            }
            else if (arrList[0] is IComparable<T>)
            {
                T max = (T)(object)arrList[0];
                for (int i = 1; i < arrList.Count; i++)
                {
                    if (max.CompareTo((T)(object)arrList[i]) <= 0)
                    {
                        max = (T)(object)arrList[i];
                    }
                }
                return max;
            }
            else
            {
                throw new ArgumentException("The list elements must implement IComparable.");
            }
        }
    }
}
