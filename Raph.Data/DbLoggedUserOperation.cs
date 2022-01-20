using Raph.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace Raph.Data
{
    public class DbLoggedUserOperation
    {

        /// <summary>
        /// Query to add logged in User to database
        /// </summary>
        /// <param name="customer"></param>
        public static void AddLoggedUserQuery(Customer customer)
        {
            using var connected = Database.GetConnection();
            connected.Open();

       //   var queryLoggedCustomer = "INSERT INTO LoggedUserTable VALUES(@CustomerId,@Email,@Password)";
            SqlCommand _sqlCommand = new SqlCommand("AddLoggedUserQuery", connected)
            {
                CommandType = CommandType.StoredProcedure
            };

        //  SqlCommand _sqlCommand = new SqlCommand(queryLoggedCustomer, connected);
            _sqlCommand.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
            _sqlCommand.Parameters.AddWithValue("@PassWord", customer.Password);
            _sqlCommand.Parameters.AddWithValue("@Email", customer.EmailAddress);
            _sqlCommand.ExecuteNonQuery();

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public static int LoggedInUser(string email, string password)
        {           
            int rowcount = 0;             
               
            using (var connected = Database.GetConnection())
            {
                connected.Open();
           //   var queryLoggedCustomer = ("SELECT COUNT(*) FROM LoggedUserTable WHERE Email = @email AND Password = @password");
                SqlCommand _sqlCommand = new SqlCommand("LoggedInUser", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

           //   SqlCommand _sqlCommand = new SqlCommand(queryLoggedCustomer, connected);
                _sqlCommand.Parameters.AddWithValue("@Email", email);
                    _sqlCommand.Parameters.AddWithValue("@PassWord", password);

                    rowcount = (int)_sqlCommand.ExecuteScalar();

            }

            return rowcount;
        }
    }
}
