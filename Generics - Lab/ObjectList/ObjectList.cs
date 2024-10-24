using System.Collections;

namespace ObjectList
{
    public class ObjectList : IEnumerable<object>
    {
        private List<object> elements;

        public ObjectList()
        {
            elements = new List<object>();
        }

        public void Add(object obj)
        {
            elements.Insert(0, obj);
        }

        public void Append(object obj)
        {
            elements.Add(obj);
        }

        public void Clear()
        {
            elements.Clear();
        }

        public IEnumerator<object> GetEnumerator()
        {
            foreach (object obj in elements)
            {
                yield return obj;
            }
        }

        public object RemoveFirst()
        {
            object firstObj = elements[0];
            elements.RemoveAt(0);
            return firstObj;
        }

        public object RemoveLast()
        {
            object lastObj = elements[^1];
            elements.RemoveAt(elements.Count - 1);
            return lastObj;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
