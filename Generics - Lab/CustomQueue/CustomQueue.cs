using System.Collections;

namespace CustomQueue
{
    public class CustomQueue<T> : IEnumerable<T>
    {
        private readonly List<T> values;
        private const string EmptyQueueErrorMsg = "The queue is empty!";

        public CustomQueue()
        {
            values = new List<T>();
        }

        public int Count
        {
            get
            {
                return values.Count;
            }
        }

        public void AddElement(T element)
        {
            values.Add(element);
        }

        public T RemoveFirstElement()
        {
            if (IsQueueEmpty())
            {
                throw new InvalidOperationException(EmptyQueueErrorMsg);
            }

            T first = values.First();
            values.RemoveAt(0);
            return first;
        }

        public T GetFirstElement()
        {
            if (IsQueueEmpty())
            {
                throw new InvalidOperationException(EmptyQueueErrorMsg);
            }

            return values.First();
        }

        public IEnumerator<T> GetEnumerator()
        {
            //foreach (T item in values)
            //{
            //    yield return item;
            //}

            return new QueueEnumerator<T>(values.ToArray());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private bool IsQueueEmpty()
        {
            return Count == 0;
        }
    }
}
