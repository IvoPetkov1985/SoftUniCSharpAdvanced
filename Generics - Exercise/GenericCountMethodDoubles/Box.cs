using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> collection;

        public Box()
        {
            collection = new List<T>();
        }

        public void AddItem(T item)
        {
            collection.Add(item);
        }

        public int GreaterItemsCount(T item)
        {
            int counter = 0;

            foreach (T element in collection)
            {
                if (element.CompareTo(item) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
