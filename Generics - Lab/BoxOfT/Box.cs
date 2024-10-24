namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            data = new List<T>();
        }

        public void Add(T element)
        {
            data.Add(element);
        }

        public T Remove()
        {
            T element = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return element;
        }

        public int Count { get { return data.Count; } }
    }
}
