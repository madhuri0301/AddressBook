using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book System");

            //user details
            ContactDetails contactdetails = new ContactDetails("Harshu","Patil","GujarLane","Shahada","Maharashtra",425409,76872899,"harshupatil@gmail.com");
            Console.WriteLine("Contact Detail is Created for : " + contactdetails.Firstname+ " " + contactdetails.Lastname);
            Console.WriteLine("Address Is :" +contactdetails.Address);
            Console.WriteLine("City Is : " + contactdetails.City);
            Console.WriteLine("State Is : " + contactdetails.State);
            Console.WriteLine("Zip Is : " + contactdetails.Zip);
            Console.WriteLine("Phone Number Is : " + contactdetails.PhoneNumber);
            Console.WriteLine("Email Is : " + contactdetails.Email);
        }
    }
}
