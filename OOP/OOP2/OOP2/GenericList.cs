using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{    
    public class GenericList<T>
    {
        private static readonly int MAX_CAPACITY = 5;
        private T[] arrList;

        private int count;
        public int Count
        {
            get { return this.count; }            
        }

        public GenericList()
        {
            arrList = new T[MAX_CAPACITY];
            this.count = 0;           
        }

        public void Add(T element)
        {
            if(count == arrList.Length)
            {
                ExtendArray();
            }
            InsertAt(count, element);
            count++;
        }

        private void ExtendArray()
        {
            T[] extendedArr = new T[MAX_CAPACITY * 2];
            Array.Copy(arrList, 0, extendedArr, 0, arrList.Length);
            arrList = extendedArr;
        }

        public void RemoveAt(int index)
        {
            if(index >= count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
            }
            else
            {
                List<T> temp = new List<T>(arrList);
                temp.RemoveAt(index);
                arrList = temp.ToArray<T>();
                count--;
            }            
        }

        public void InsertAt(int index, T element)
        {
            if(index > count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
            }
            else if(index == arrList.Length)
            {
                ExtendArray();
            }
            arrList[index] = element;       
        }

        public void Clear()
        {
            List<T> temp = new List<T>(arrList);
            temp.Clear();
            arrList = temp.ToArray<T>();
            count = 0;
        }

        public int Find(T element)
        {
            if (Array.IndexOf(arrList, element) == -1)
            {
                throw new ArgumentException(String.Format("The element {0} do not exist in the list!", element));
            }
            int index = Array.IndexOf(arrList, element);

            return index;
        }

        public T this[int index]
        {
            get 
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
                }
                return this.arrList[index]; 
            }
            set 
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index: " + index);
                }
                this.arrList[index] = value; 
            }
        }

        

        public override string ToString()
        {
            string elements = String.Join("\t", arrList);
            return elements;
        }
    }
}
