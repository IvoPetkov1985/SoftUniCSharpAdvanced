namespace DoublyLinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniLinkedList list = new SoftUniLinkedList();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);

            Console.WriteLine(list.RemoveLast());

            list.AddFirst(15);

            list.ForEach(x => Console.WriteLine(x));

            int[] listAsArray = list.ToArray();

            Console.WriteLine(string.Join(", ", listAsArray));
        }
    }
}
