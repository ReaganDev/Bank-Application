using Raph.Commons;
using System;
using System.Collections.Generic;

namespace Raph.Models
{
    public class Customer
    {
        public string CustomerId { get; set; } = Guid.NewGuid().ToString();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateCreated { get;set; }

        public ICollection<Account> Accounts { get; set; }

        public string FullName
        {
            get
            {
                return Utilities.FirstCharacterToUpper(Utilities.RemoveDigitFromStart(LastName)) + " " +
                  Utilities.FirstCharacterToUpper(Utilities.RemoveDigitFromStart(FirstName));
            }
            set { }
        }

        public Customer()
        {
            Accounts = new HashSet<Account>();
            DateCreated = DateTime.Now;

        }

        public Customer(string firstName, string lastName, string emailAddress, string phone_no, string pin): this()
        {

            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phone_no;
            Password = pin;

        }



    }
}
