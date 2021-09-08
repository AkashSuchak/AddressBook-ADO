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
            //manager.CreateDatabase();
            
            //UC2
            Person person = new Person();
            person.FirstName = "Akash";
            person.LastName = "Suchak";
            person.Address = "GUJ";
            person.PhoneNumber = "9090909090";
            person.ZipCode = 380001;
            person.City = "AMD";
            person.State = "GUJ";
            person.EmailId = "example@gmail.com";
            person.AddressBookName = "Akash";
            person.Type = "Family";

            manager.AddEmployee(person);
        }
    }    
}
