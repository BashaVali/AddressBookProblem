using AddressBookProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    class AddressBook
    {
        public static List<Contact> People = new List<Contact>();
        public static void Contact()
        {
            Contact person = new Contact();

            Console.Write("Enter First Name: ");
            person.firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.lastName = Console.ReadLine();

            Console.Write("Enter City : ");
            person.city = Console.ReadLine();

            Console.Write("Enter State : ");
            person.state = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            person.zipCode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.phoneNumber = Console.ReadLine();

            Console.Write("Enter EmailId: ");
            person.EmailId = Console.ReadLine();

            People.Add(person);
        }
        public static void PrintCustomer(Contact person)
        {
            Console.WriteLine("First Name: " + person.firstName);
            Console.WriteLine("Last Name: " + person.lastName);
            Console.WriteLine("City : " + person.city);
            Console.WriteLine("State : " + person.state);
            Console.WriteLine("ZipCode : " + person.zipCode);
            Console.WriteLine("Phone Number: " + person.phoneNumber);
            Console.WriteLine("Email Id: " + person.EmailId);
            Console.WriteLine("-------------------------------------------");
        }
        public static void ListingPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintCustomer(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

    }
}
