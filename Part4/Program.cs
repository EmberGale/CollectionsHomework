namespace Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("\nВведите ФИО:");
            String fullname = Console.ReadLine();
            Console.WriteLine("\nВведите название улицы:");
            String streetname = Console.ReadLine();
            Console.WriteLine("\nВведите название дома:");
            String housename = Console.ReadLine();
            Console.WriteLine("\nВведите номер квартиры:");
            String flatnum = Console.ReadLine();
            Console.WriteLine("\nВведите номер телефона:");
            String phonenum = Console.ReadLine();
            Console.WriteLine("\nВведите номер домашнего телефона:");
            String flatphone = Console.ReadLine();
            addressBook.CreateXML(fullname, streetname, housename, flatnum, phonenum, flatphone);
        }
    }
}
