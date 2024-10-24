namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] names = ArrayCreator.Create(5, "Pesho");

            Console.WriteLine(string.Join(", ", names));

            int[] numbers = ArrayCreator.Create(20, 3);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
