namespace CustomLinkedList
{
    internal class MyLinkedList
    {
        private CustomNode head;

        private CustomNode tail;

        public int Count { get; set; }

        public void AddFirst(int value)
        {
            if (Count == 0)
            {
                head = tail = new CustomNode(value);
            }
            else
            {
                CustomNode newHead = new(value);
                newHead.Next = head;
                head.Previous = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(int value)
        {
            if (Count == 0)
            {
                tail = head = new CustomNode(value);
            }
            else
            {
                CustomNode newTail = new(value);
                newTail.Previous = tail;
                tail.Next = newTail;
                tail = newTail;
            }

            Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            int firstElementToRemove = head.Value;
            head = head.Next;

            if (head != null)
            {
                head.Previous = null;
            }
            else
            {
                tail = null;
            }

            Count--;
            return firstElementToRemove;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            int lastElementToRemove = tail.Value;
            tail = tail.Previous;

            if (tail != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
            }

            Count--;
            return lastElementToRemove;
        }

        public void ForEach(Action<int> action)
        {
            CustomNode current = head;

            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        public int[] ToArray()
        {
            int[] resultArray = new int[Count];
            int counter = 0;

            CustomNode current = head;

            while (current != null)
            {
                resultArray[counter] = (int)current.Value;
                current = current.Next;
                counter++;
            }

            return resultArray;
        }
    }
}
