namespace CustomQueue
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomQueue<int> intsQueue = new CustomQueue<int>();

            intsQueue.AddElement(15);
            intsQueue.AddElement(25);
            intsQueue.AddElement(35);
            intsQueue.AddElement(45);
            intsQueue.AddElement(55);

            Console.WriteLine(string.Join(", ", intsQueue));
            Console.WriteLine(intsQueue.RemoveFirstElement());
            Console.WriteLine(intsQueue.RemoveFirstElement());
            Console.WriteLine(string.Join(", ", intsQueue));

            CustomQueue<string> names = new CustomQueue<string>();

            names.AddElement("Gosho");
            names.AddElement("Pencho");
            names.AddElement("Nasko");
            names.AddElement("Albena");

            Console.WriteLine(names.GetFirstElement());
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine(names.RemoveFirstElement());
            Console.WriteLine(names.RemoveFirstElement());
        }
    }
}
