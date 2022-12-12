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
        public static void Edit()
        {
            if (People.Count != 0)
            {
                Console.WriteLine("Enter the contact to modify:");
                string Edited = Console.ReadLine();
                foreach (var person in People)
                {
                    if (person.firstName.ToUpper() == Edited.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to Edit the Contact In AddressBook: ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Phone Number ");
                            Console.WriteLine("Enter 4 to Change Address ");
                            Console.WriteLine("Enter 5 to Change City ");
                            Console.WriteLine("Enter 6 to Change State ");
                            Console.WriteLine("Enter 7 to Change Pincode ");
                            Console.WriteLine("Enter 8 to Exit ");
                            int Check = Convert.ToInt32(Console.ReadLine());
                            switch (Check)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.firstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last Name: ");
                                    person.lastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New City: ");
                                    person.city = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New State: ");
                                    person.state = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.phoneNumber = Console.ReadLine();
                                    break;
                                case 6:

                                    Console.WriteLine("Enter the New Pin Code: ");
                                    person.zipCode = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.EmailId = Console.ReadLine();
                                    break;
                                case 8:
                                    return;

                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter the valid name!");
                    }

                }


            }
        }
        public static void DeleteContact()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string Remove = Console.ReadLine();
            foreach (var person in People.ToList())
            {
                if (person.firstName.ToUpper() == Remove.ToUpper())
                {
                    People.Remove(person);
                    Console.WriteLine("Contact is deleted");
                }
                else
                {
                    Console.WriteLine("Contact is not present");
                }
            }
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
