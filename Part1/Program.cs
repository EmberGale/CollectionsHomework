namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListProcess Part1 = new ListProcess();
            Part1.CreateList();
            string result = Part1.CollectionString();
            Console.WriteLine("Изначальная коллекция:");
            Console.WriteLine(result);
            Part1.RemoveItems();
            result = Part1.CollectionString();
            Console.WriteLine("\nКоллекция после изменений (25 < x < 50):");
            Console.WriteLine(result);
        }
    }
}
