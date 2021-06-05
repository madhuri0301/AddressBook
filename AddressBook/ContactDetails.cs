using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class ContactDetails
    {
        //private variables
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string state;
        private long zip;
        private long phoneNumber;
        private string email;

        //passing parameters
        public ContactDetails(string firstname, string lastname, string address, string city, string state, long zip, long phoneNumber, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        //to get and set the values
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public long Zip { get => zip; set => zip = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }

    }
         
}
