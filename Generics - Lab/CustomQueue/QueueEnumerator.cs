using System.Collections;

namespace CustomQueue
{
    public class QueueEnumerator<T> : IEnumerator<T>
    {
        private readonly List<T> list;
        private int index = -1;

        public QueueEnumerator(params T[] values)
        {
            this.list = new List<T>(values);
            Reset();
        }

        public T Current => list[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index++;
            return index < list.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
