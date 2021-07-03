using System;

namespace AddressBook
{
    class program
    {
        static void Main(string[] args)
        {
            int adno = 0;
            Console.WriteLine("Welcome To The Address Book System");

            AddressBookProgram AD = new AddressBookProgram();                     // Creating a Object of Main Class
            AddressBookProgram AD2 = new AddressBookProgram();
            do
            {
                Console.WriteLine("1. Personal Address Book \n 2. Shop Address Book \n.Exit");
                Console.WriteLine("Select the Address Book:");
                adno = Convert.ToInt32(Console.ReadLine());
                switch (adno)
                {
                    case 1:
                        ManageADBOOK(AD);
                        break;
                    case 2:
                        ManageADBOOK(AD2);
                        break;
                    case 3:
                        Console.WriteLine("Thank You For Exiting");
                        break;
                }
            } while (adno < 3);


        }
        public static void ManageADBOOK(AddressBookProgram ABP)
        {
            //while (true)                                // Checking a Choice with Switch Statement
            // {
            Console.WriteLine("1. Adding Contact \n2. Show All Contact \n3. Edit \n4. Delete \n5.Add Multiple Person \n6. Exit");
            Console.WriteLine("Enter a Your Choice :");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    ContactDetails ContactDetails = ABP.GetContactInput();
                    ABP.addContact(ContactDetails);

                    Console.WriteLine("Contact Added Successfully");
                    break;

                case 2:
                    ABP.ShowContactOutput();
                    Console.WriteLine("Please Enter Your Information");
                    break;

                case 3:
                    ABP.EditContact();
                    //Console.WriteLine("Contact Edited Succesfully");
                    break;
                case 4:
                    ABP.DeleteContact();
                    break;
                case 5:
                    ABP.DuplicateContact();
                    break;
                case 6:
                    Console.WriteLine("Thank You We are Exiting");
                    return;
                default:
                    Console.WriteLine("Sorry You are Type Wrong Choice");
                    break;

            }
            //}
        }
    }
}
