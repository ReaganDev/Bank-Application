using Raph.Core.Interface;
using Raph.Data;
using Raph.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Raph.Core
{
    public class AuthenticationRepository: IAuthenticationRepository 
    {
        private readonly CustomerRespository _customerRespository;
        public static string loggedInUserId;

        public AuthenticationRepository()
        {
            _customerRespository = new CustomerRespository();
        }

        #region Login  



        /// <summary>
        /// validate credential from login
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsValidCredential(string email, string password)
        {
            bool pswMatch = false;

            //check if user database contains at least a record
            if (_customerRespository.RowCount() < 1)
            {
                MessageBox.Show("No record Found in data source", "Error", MessageBoxButton.OK);
                pswMatch = false;
            }

            var user = DbLoggedUserOperation.LoggedInUser(email, password);

            if( user  == 1)
            {
                pswMatch = true;   
            }

            return pswMatch;
           
        }

        #endregion

        /// <summary>
        /// add unique user to database
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        #region
        public bool Register(Customer customer)
        {
            if (EmailExist(customer.EmailAddress) == true)
            {
                MessageBox.Show("Email Already Exist", "Error", MessageBoxButton.OK);
                return false;
            }



            if (_customerRespository.AddUser(customer))
            {
                return true;
            }
            return false;
        }

        public bool CreateNewAccount(Account account)
        {
            if (_customerRespository.AddAccount(account))
            {
                return true;
            }
            return false;
        }
       


        /// <summary>
        /// email exist
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        internal bool EmailExist(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                var user = DbCustomerOperation.MailExist(email);
                // loop through data base to check for mail
               
                    if(user > 0)
                    {
                        return true;
                    }                        
                          
            }
            return false;
        }

        bool IAuthenticationRepository.EmailExist(string email)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
