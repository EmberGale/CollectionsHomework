namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phones phones = new Phones();
            Console.WriteLine("Введите команду:");
            Console.WriteLine("1. Добавить пользователей");
            Console.WriteLine("2. Найти пользователя");
            byte choice = byte.Parse(Console.ReadLine());

            while (choice < 3 && choice > 0)
            {
                if (choice == 1)
                {
                    Console.WriteLine("Введите ФИО:");
                    string fullname = Console.ReadLine();
                    string phoneNumberString = " ";
                    int phoneNumber = 0;
                    while (!string.IsNullOrEmpty(phoneNumberString))
                    {
                        Console.WriteLine("Введите его номер телефона:");
                        phoneNumberString = Console.ReadLine();
                        if (!string.IsNullOrEmpty(phoneNumberString))
                        {
                            phoneNumber = int.Parse(phoneNumberString);
                            phones.CreateDictionary(phoneNumber, fullname);
                        }
                    }
                    Console.WriteLine("\nТекущее содержание:");
                    string result = phones.DictionaryString();
                    Console.WriteLine(result);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Введите номер телефона:");
                    int id = int.Parse(Console.ReadLine());
                    string result = phones.DictionaryFindById(id);
                    Console.WriteLine(result);
                }
                else
                {
                    break;
                }
                Console.WriteLine("\nВведите комманду:");
                Console.WriteLine("1. Добавить пользователей");
                Console.WriteLine("2. Найти пользователя");
                choice = byte.Parse(Console.ReadLine());
            }
        }

    }
}
