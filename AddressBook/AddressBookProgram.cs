using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookProgram
    {
        private List<ContactDetails> ContactList;            // Declearing list with Model Class  

        public AddressBookProgram()
        {
            ContactList = new List<ContactDetails>();        // Initaillizing list 
        }
        public void addContact(ContactDetails createPerson)
        {
            Console.WriteLine("Adding a New Contact for " + createPerson.Firstname);      // Creating a Method and Adding object in a list 
            ContactList.Add(createPerson);
        }
        public ContactDetails GetContactInput()                      // Getting a Input from User
        {
            Console.WriteLine("Enter The Name");
            String fname = Console.ReadLine();
            Console.WriteLine("Enter The Last Name");
            String lname = Console.ReadLine();
            Console.WriteLine("Enter The Address");
            String address = Console.ReadLine();
            Console.WriteLine("Enter The City");
            String city = Console.ReadLine();
            Console.WriteLine("Enter The State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter The Zip");
            long zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Phone Number");
            String phoneNo = Console.ReadLine();
            Console.WriteLine("Enter The Email");
            String email = Console.ReadLine();

            ContactDetails contact = new ContactDetails(fname, lname, address, city, state, zip, phoneNo, email);
            return contact;
        }

        public void ShowContactOutput()  //to print output
        {
            for (int i = 0; i < ContactList.Count; i++)
            {
                Console.WriteLine("First Name:" + ContactList[i].Firstname);
                Console.WriteLine("Last Name:" + ContactList[i].Lastname);
                Console.WriteLine("Address:" + ContactList[i].Address);
                Console.WriteLine("City:" + ContactList[i].City);
                Console.WriteLine("State:" + ContactList[i].State);
                Console.WriteLine("Zip Code:" + ContactList[i].Zip);
                Console.WriteLine("Phone No:" + ContactList[i].PhoneNumber);
                Console.WriteLine("EMail ID:" + ContactList[i].Email);
                Console.WriteLine("");

            }
        }
        public void EditContact() //to edit contact
        {
            String EName;
            int temp = 0;
            ShowContactOutput();
            Console.WriteLine("Enter the Name of Contact you want to Edit:");
            EName = Console.ReadLine();

            for (int i = 0; i < ContactList.Count; i++)
            {
                if (EName.Equals(ContactList[i].Firstname))
                {
                    temp = 1;
                    Console.WriteLine("The Contact Found...");
                    UpdateContact(i);
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("The Contact is Not Found...");
            }
        }
        public void UpdateContact(int pos)                  //updating the contact 
        {
            int choice;
            String LName, Address, City, State, PhoneNo, EMailID;
            long zip;
            Console.WriteLine("Choose the Feild to Edit:");
            Console.WriteLine("1. Last Name \t 2. Address \t 3. City \t 4. State \t 5. Zip \t 6. Phone No \t 7. EMail ID");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)                                 //switch case to edit the information you want to edit
            {
                case 1:
                    Console.WriteLine("Enter the New Last Name:");
                    LName = Console.ReadLine();
                    ContactList[pos].Lastname = LName;
                    break;
                case 2:
                    Console.WriteLine("Enter the New Address:");
                    Address = Console.ReadLine();
                    ContactList[pos].Address = Address;
                    break;
                case 3:
                    Console.WriteLine("Enter the New City:");
                    City = Console.ReadLine();
                    ContactList[pos].City = City;
                    break;
                case 4:
                    Console.WriteLine("Enter the New  State:");
                    State = Console.ReadLine();
                    ContactList[pos].State = State;
                    break;
                case 5:
                    Console.WriteLine("Enter the New  Zip:");
                    zip = Convert.ToInt32(Console.ReadLine());
                    ContactList[pos].Zip = zip;
                    break;
                case 6:
                    Console.WriteLine("Enter the New  Phone No:");
                    PhoneNo = Console.ReadLine();
                    ContactList[pos].PhoneNumber = PhoneNo;
                    break;
                case 7:
                    Console.WriteLine("Enter the New EMail ID:");
                    EMailID = Console.ReadLine();
                    ContactList[pos].Email = EMailID;
                    break;
            }
            Console.WriteLine("Contact Edited Succesfully");
        }
        public void DeleteContact()
        {
            String EName;
            int temp = 0;
            ShowContactOutput();
            Console.WriteLine("Enter the Name of Contact you want to Delete:");
            EName = Console.ReadLine();

            for (int i = 0; i < ContactList.Count; i++)
            {
                if (EName.Equals(ContactList[i].Firstname))
                {
                    temp = 1;
                    Console.WriteLine("The Contact Found...");
                    ContactList.RemoveAt(i);
                    Console.WriteLine("Contact Deleted Succesfully");
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("The Contact is Not Found...");
            }
        }
    }
}
