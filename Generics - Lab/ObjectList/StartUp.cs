namespace ObjectList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ObjectList list = new ObjectList();

            list.Append("Gosho");
            list.Append("Pesho");
            list.Add("Dimi");
            list.Add("Jimi");
            list.Append(10);

            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine(list.RemoveFirst());
            Console.WriteLine(list.RemoveLast());

            foreach (object obj in list)
            {
                Console.WriteLine(obj.ToString());
            }

            list.Clear();
        }
    }
}
