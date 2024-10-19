namespace CustomLinkedList
{
    internal class CustomNode
    {
        public CustomNode(int value)
        {
            Value = value;
        }

        public int Value { get; set; }

        public CustomNode Previous { get; set; }

        public CustomNode Next { get; set; }
    }
}
