using Raph.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace Raph.Data
{
    public class DbCustomerOperation
    {


       
        /// <summary>
        /// Query to add customer to database
        /// </summary>
        /// <param name="customer"></param>
        public static void AddUserQuery(Customer customer)
        {
            using var connected = Database.GetConnection();
            connected.Open();

           // var queryCustomer = "INSERT INTO CustomerTable VALUES(@CustomerId, @FirstName,@LastName,@Password,@EmailAddress,@PhoneNumber,@DateCreated)";

            SqlCommand _sqlCommand = new SqlCommand("AddUser", connected)
            {
                CommandType = CommandType.StoredProcedure
            };
            _sqlCommand.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
            _sqlCommand.Parameters.AddWithValue("@Firstname", customer.FirstName);
            _sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
            _sqlCommand.Parameters.AddWithValue("@PassWord", customer.Password);
            _sqlCommand.Parameters.AddWithValue("@EmailAddress", customer.EmailAddress);
            _sqlCommand.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
            _sqlCommand.Parameters.AddWithValue("@DateCreated", customer.DateCreated);

            _sqlCommand.ExecuteNonQuery();


        }

        /// <summary>
        /// Query Customer using ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Customer GetCustomerById(string id)
        {
            Customer customer = null;
            using (var connected = Database.GetConnection())
            {
                connected.Open();
                //var queryCustomer = ("SELECT * FROM CustomerTable WHERE CustomerId = @id");

                SqlCommand _sqlCommand = new SqlCommand("GetCustomerById", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _sqlCommand.Parameters.AddWithValue("@id", id);

                var readCustomer = _sqlCommand.ExecuteReader();

                while (readCustomer.Read())
                {


                    customer = new Customer
                    {
                        CustomerId = readCustomer["CustomerId"].ToString(),
                        FirstName = readCustomer["FirstName"].ToString(),
                        LastName = readCustomer["LastName"].ToString(),
                        EmailAddress = readCustomer["EmailAddress"].ToString(),
                        PhoneNumber = readCustomer["PhoneNumber"].ToString(),
                        Password = readCustomer["Password"].ToString()
                    };
                     
                }

            }

            return customer;
        }





        /// <summary>
        /// get customer details by mail
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Customer GetCustomerByEmail(string email)
        {

            Customer customer;
            using (var connected = Database.GetConnection())
            {
                connected.Open();
                //r queryCustomer = ("SELECT * FROM CustomerTable WHERE EmailAddress = @email");

                SqlCommand _sqlCommand = new SqlCommand("GetCustomerByEmail", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

                //lCommand _sqlCommand = new SqlCommand(queryCustomer, connected);
                _sqlCommand.Parameters.AddWithValue("@EmailAddress", email);

                var readCustomer = _sqlCommand.ExecuteReader();

                while (readCustomer.Read())
                {


                    customer = new Customer
                    {
                        CustomerId = readCustomer["CustomerId"].ToString(),
                        FirstName = readCustomer["FirstName"].ToString(),
                        LastName = readCustomer["LastName"].ToString(),
                        EmailAddress = readCustomer["EmailAddress"].ToString(),
                        PhoneNumber = readCustomer["PhoneNumber"].ToString(),
                        Password = readCustomer["Password"].ToString()

                    };
                return customer;
                }


            }

            return null;
           
        }





        /// <summary>
        /// Get the number of rows in a table
        /// </summary>
        /// <returns></returns>
        public static int Rowcount()
        {
            int rowcount = 0;

            using (var connected = Database.GetConnection())
            {
                connected.Open();
               //ar queryCustomer = ("SELECT COUNT(*) FROM CustomerTable");
                SqlCommand _sqlCommand = new SqlCommand("CountRows", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };


              //SqlCommand _sqlCommand = new SqlCommand(queryCustomer, connected);

                rowcount = (int) _sqlCommand.ExecuteScalar();

            }

                return rowcount;
        }




        /// <summary>
        ///  check if mail already exist in database
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static int MailExist(string email)
        {

            int rowcount = 0;
            using (var connected = Database.GetConnection())
            {
                connected.Open();
            //  var queryLoggedCustomer = ("SELECT COUNT(*) FROM LoggedUserTable WHERE Email = @email ");

                SqlCommand _sqlCommand = new SqlCommand("MailExist",connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

            //  SqlCommand _sqlCommand = new SqlCommand(queryLoggedCustomer, connected);
                _sqlCommand.Parameters.AddWithValue("@Email", email);
                rowcount = (int)_sqlCommand.ExecuteScalar();

            }

            return rowcount;

        }

        //DELETE CUSTOMER USING ID









    }
}
