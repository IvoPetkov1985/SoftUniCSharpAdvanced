using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodInteger
{
    public class Box<T>
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

        public void SwapItems(int firstIndex, int secondIndex)
        {
            (collection[firstIndex], collection[secondIndex]) = (collection[secondIndex], collection[firstIndex]);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (T element in collection)
            {
                result.AppendLine($"{typeof(T)}: {element}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
