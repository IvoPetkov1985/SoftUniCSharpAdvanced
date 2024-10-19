namespace CustomLinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            MyLinkedList customList = new ();

            customList.AddLast(1);
            customList.AddLast(2);
            customList.AddLast(3);
            customList.AddLast(4);
            customList.AddLast(5);
            customList.AddLast(10);
            customList.AddLast(20);
            customList.AddLast(30);
            customList.AddFirst(100);
            customList.AddFirst(200);
            customList.AddFirst(300);
            customList.AddFirst(400);

            customList.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(customList.RemoveFirst());
            Console.WriteLine(customList.RemoveLast());

            int[] array = customList.ToArray();

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
