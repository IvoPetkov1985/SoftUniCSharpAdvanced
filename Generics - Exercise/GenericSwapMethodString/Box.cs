using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
{
    public class Box<T>
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

        public void SwapElements(int firstIndex, int secondIndex)
        {
            T buff = collection[firstIndex];
            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = buff;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in collection)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
