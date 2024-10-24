using System.Collections;

namespace CustomStack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private const string EmptyStackErrorMsg = "Ther stack is empty!";
        private readonly List<T> list;

        public CustomStack()
        {
            list = new List<T>();
        }

        public void AddElement(T element)
        {
            list.Insert(0, element);
        }

        public T GetPeekElement()
        {
            if (IsStackEmpty())
            {
                throw new InvalidOperationException(EmptyStackErrorMsg);
            }

            return list.First();
        }

        public T RemoveTopElement()
        {
            if (IsStackEmpty())
            {
                throw new InvalidOperationException(EmptyStackErrorMsg);
            }

            T element = list.First();
            list.RemoveAt(0);
            return element;
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private bool IsStackEmpty()
        {
            return Count == 0;
        }
    }
}
