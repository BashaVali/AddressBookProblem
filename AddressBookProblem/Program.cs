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
                Console.WriteLine("1. Create a new Contact \n2. Edit a Contact \n3. Delete a Contact\n4. Exit \n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter your details :-\n");
                            AddressBook.Contact();
                        break;
                    case 2:
                             AddressBook.Edit();                       
                        break;
                    case 3:
                        AddressBook.DeleteContact();
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
