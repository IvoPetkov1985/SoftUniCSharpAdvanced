using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
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
