using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
  
    }
    class AddressBook
    {
        public  void PersonDetails()
        {
            Console.Write("Enter First Name: ");
            String firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            var Addresses = Console.ReadLine();

            Console.Write("Enter City : ");
            string city = Console.ReadLine();

            Console.Write("Enter State : ");
            string state = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            string zipCode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter EmailId: ");
            string Email = Console.ReadLine();
            //Adding fetched details to list
            List<string> Contact = new List<string>();
            Contact.Add(firstName);
            Contact.Add(lastName);
            Contact.Add(city);
            Contact.Add(state);
            Contact.Add(zipCode);
             Contact.Add(phoneNumber);
            Contact.Add(Email);
            foreach (string i in Contact)
                Console.WriteLine(i);

        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book!");
            AddressBook addressBook = new AddressBook();
            addressBook.PersonDetails();
        }
    }
}