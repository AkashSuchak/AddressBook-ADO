using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace AddressBook_ADO
{
    class ReadWriteJson
    {
        //File Path of JSON file
        string filePath = @"C:\Users\DELL\source\repos\AddressBook-ADO\AddressBook-ADO\AddressRecord.json";
        public void WriteToFile(Dictionary<string, AddressBookBuider> addressBookDictionary)
        {
            foreach (AddressBookBuider obj in addressBookDictionary.Values)
            {
                foreach (Contacts contact in obj.addressBook.Values)
                {
                    //Serialize
                    string json = JsonConvert.SerializeObject(contact);
                    File.WriteAllText(filePath, json); //AddToFile
                }
            }
            Console.WriteLine("\nSuccessfully added to JSON file.");
        }
        public void ReadFromFile()
        {
            //Deserialize
            Contacts contact = JsonConvert.DeserializeObject<Contacts>(File.ReadAllText(filePath));
            Console.WriteLine(contact.ToString());
        }
    }
}