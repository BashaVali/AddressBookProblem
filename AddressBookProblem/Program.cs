
using System;
namespace AddressBookProblem
{
    public class program
    {
        public static void Main(string[] args)
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("Welcome to Address Book Problem Statement\n");
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1. Create a new Contact \n2. Exit \n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter your details :-\n");
                            AddressBook.Contact();
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        condition = false;
                        break;
                }
            }
        }
    }
}
