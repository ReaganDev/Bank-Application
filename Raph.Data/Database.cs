
using Raph.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Raph.Data
{
    public class Database
    {
        public static List<Customer> ListOfCustomer { get; set; } = new List<Customer>();
        public static List<Account> ListOfAccount { get; set; } = new List<Account>();
        public static List<Transaction> ListOfTransaction { get; set; } = new List<Transaction>();        
      
        /// <summary>
        /// Returns an Open connection 
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {

            string connect = @"Data Source=LAPTOP-0VSJ0RU3\MSSQLSERVER01;Initial Catalog=BankDb;Integrated Security=True";

            //create sql connection object
            SqlConnection myConnection = new SqlConnection(connect);

            return myConnection;

        }     

    }
}
