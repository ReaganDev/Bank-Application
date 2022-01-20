using Raph.Core.Interface;
using Raph.Data;
using Raph.Models;
using System;

namespace Raph.Core
{
    public class CustomerRespository : ICustomerRepository
    {
        private readonly AccountRepository _accountRepository;
        public int CountRow { get; set; }

        public CustomerRespository()
        {
            _accountRepository = new AccountRepository();
            CountRow = DbCustomerOperation.Rowcount();
        }









        #region //DONE ALREADY

        //Add User using model
        public bool AddUser(Customer customer)
        {
            //do a row count of the table of your database
            CountRow = DbCustomerOperation.Rowcount();

            //add customer to loggedIn database
            DbLoggedUserOperation.AddLoggedUserQuery(customer);

            // add customer to the database
            DbCustomerOperation.AddUserQuery(customer);

           

            foreach (var account in customer.Accounts)
            {
                _accountRepository.AddAccount(account);
            }

            //row count after addition to database
            var CountRowAfterAddition = DbCustomerOperation.Rowcount();

            if (CountRow <= CountRowAfterAddition)
            {
                CountRow = CountRowAfterAddition;
                return true;
            }
            return false;
        }

        public bool AddAccount(Account account)
        {
            CountRow = DbAccountOperation.Rowcount();

            
             _accountRepository.AddAccount(account);
           

            //row count after addition to database
            var CountRowAfterAddition = DbAccountOperation.Rowcount();

            if (CountRow <= CountRowAfterAddition)
            {
                CountRow = CountRowAfterAddition;
                return true;
            }
            return false;

        }

        //count rows
        public int RowCount() 
        {
            return DbCustomerOperation.Rowcount();
        }




        //get user by id
        public Customer GetCustomerById(string id)
        {
            var customerQuery = DbCustomerOperation.GetCustomerById(id);    
            return customerQuery;
        }



        // get user by email
        public Customer GetCustomerByEmail(string email)
        {

            var customerQuery = DbCustomerOperation.GetCustomerByEmail(email);
           
            return customerQuery;
        }

        #endregion









        #region //NOT DONE YET

        //Remove user using id
        public bool RemoveUser(String id)
        {
            CountRow = Database.ListOfCustomer.Count;
            foreach (var customer in Database.ListOfCustomer)
            {
                if (customer.CustomerId == id)
                {
                    Database.ListOfCustomer.Remove(customer);
                    var CountRowAfterDeleting = Database.ListOfCustomer.Count;
                    if (CountRow <= CountRowAfterDeleting)
                    {
                        return false;
                    }
                }

            }

            return true;
        }
        #endregion
    }



}
