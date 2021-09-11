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
            
            
            Person person = new Person();
            //UC2 and 3
            person.FirstName = "Hello";
            person.LastName = "Suchak";
            person.Address = "GUJ";
            person.PhoneNumber = "9090909090";
            person.ZipCode = 380001;
            person.City = "AMD";
            person.State = "GUJ";
            person.EmailId = "example@gmail.com";
            person.AddressBookName = "Akash";
            person.Type = "Family";

            manager.AddPerson(person);

            //UC4
            person.AddressBookName = "Akash";
            person.Address = "AMD";
            manager.UpdatePerson(person);

            //UC5
            person.FirstName = "Hello";
            manager.DeletePerson(person);
        }
    }    
}
