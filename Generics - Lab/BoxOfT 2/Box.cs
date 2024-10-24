namespace BoxOfT_2
{
    public class Box<T>
    {
        private Stack<T> data;

        public Box()
        {
            this.data = new Stack<T>();
        }

        public void Add(T item)
        {
            data.Push(item);
        }

        public T Remove()
        {
            return data.Pop();
        }

        public int Count
        {
            get
            {
                return data.Count;
            }
        }
    }
}
