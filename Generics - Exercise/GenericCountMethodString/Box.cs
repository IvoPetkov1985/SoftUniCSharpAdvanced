using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> collection;

        public Box()
        {
            collection = new List<T>();
        }

        public void AddElement(T element)
        {
            collection.Add(element);
        }

        public int GreaterElements(T elementToCompare)
        {
            int result = 0;

            foreach (T element in collection)
            {
                if (element.CompareTo(elementToCompare) > 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
