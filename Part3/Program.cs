namespace Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckRepeat checkRepeat = new CheckRepeat();
            String getElement = " ";
            while (!string.IsNullOrEmpty(getElement))
            {
                Console.WriteLine("\nВведите элемент:");
                getElement = Console.ReadLine();
                if (!string.IsNullOrEmpty(getElement))
                {
                    int id = int.Parse(getElement);
                    if (checkRepeat.hash.Contains(id))
                    {
                        Console.WriteLine("Данный элемент уже присутвует");
                    }
                    else
                    {
                        checkRepeat.hash.Add(id);
                        String result = checkRepeat.HashString();
                        Console.WriteLine(result);
                    }
                }

            }
        }
    }
}
