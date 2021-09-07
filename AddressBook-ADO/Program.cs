using System;

namespace AddressBook_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Address Book ADO.Net");
            Console.WriteLine("===============================");

            DatabaseManager manager = new DatabaseManager();
            //UC1
            manager.CreateDatabase();
        }
    }
}
