using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
	class AddressBookProgram
	{
		private List<ContactDetails> ContactList;            // Declearing Arraylist with Model Class  

		public AddressBookProgram()
		{
			ContactList = new List<ContactDetails>();        // Initaillizing Arraylist 
		}
		public void addContact(ContactDetails createPerson)
		{
			Console.WriteLine("Adding a New Contact for " + createPerson.Firstname);      // Creating a Method and Adding object in a Arraylist 
			ContactList.Add(createPerson);
		}
		public ContactDetails GetContactInput()                      // Getting a Input from User
		{
			Random random = new Random();
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

		public void ShowContactOutput()
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
		public void ShowSpecificContact()
		{
			Console.WriteLine("Enter the Number of Contact to See Details:");
			int no = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("First Name:" + ContactList[no - 1].Firstname);
			Console.WriteLine("Last Name:" + ContactList[no - 1].Lastname);
			Console.WriteLine("Address:" + ContactList[no - 1].Address);
			Console.WriteLine("City:" + ContactList[no - 1].City);
			Console.WriteLine("State:" + ContactList[no - 1].State);
			Console.WriteLine("Zip Code:" + ContactList[no - 1].Zip);
			Console.WriteLine("Phone No:" + ContactList[no - 1].PhoneNumber);
			Console.WriteLine("EMail ID:" + ContactList[no - 1].Email);
            Console.WriteLine("");


		}

	}
}
