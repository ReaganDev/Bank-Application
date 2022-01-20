using Raph.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace Raph.Data
{
    public class DbAccountOperation
    {
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
           //   var queryAccount = ("SELECT COUNT(*) FROM AccountTable");
                SqlCommand _sqlCommand = new SqlCommand("RowcountAccountTable", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

            //  SqlCommand _sqlCommand = new SqlCommand(queryAccount, connected);

                rowcount = (int)_sqlCommand.ExecuteScalar();

            }

            return rowcount;
        }



        /// <summary>
        /// Query to add account to database
        /// </summary>
        /// <param name="account"></param>
        public static void AddAccountQuery(Account account)
        {
            using var connected = Database.GetConnection();
            connected.Open();

       //   var queryAccount = "INSERT INTO AccountTable VALUES(@AccountId, @AccountNumber, @AccountType," +
        //      "@DateCreated,@Balance)";

            SqlCommand _sqlCommand = new SqlCommand("AddAccountQuery", connected)
            {
                CommandType = CommandType.StoredProcedure
            };

        //  SqlCommand _sqlCommand = new SqlCommand(queryAccount, connected);
            _sqlCommand.Parameters.AddWithValue("@AccountId", account.CustomerId);
            _sqlCommand.Parameters.AddWithValue("@AccountNumber", account.AcctNumber);
            _sqlCommand.Parameters.AddWithValue("@AccountType", account.AccType);
            _sqlCommand.Parameters.AddWithValue("@DateCreated", account.DateCreated);
            _sqlCommand.Parameters.AddWithValue("@Balance", account.Balance);


            _sqlCommand.ExecuteNonQuery();

        }


        // remove account



        /// <summary>
        /// Query to get an Account
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public static Account GetAccountByAccountNumber(string accountNumber)
        {
            Account account = null;
            using (var connected = Database.GetConnection())
            {
                connected.Open();
            //  var queryAccount = ("SELECT * FROM AccountTable WHERE AccountNumber = @accountNumber");

                SqlCommand _sqlCommand = new SqlCommand("GetAccountByAccountNumber", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

            //  SqlCommand _sqlCommand = new SqlCommand(queryAccount, connected);
                _sqlCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                var readAccount = _sqlCommand.ExecuteReader();

                while (readAccount.Read())
                {


                    account = new Account
                    {
                        CustomerId = readAccount["CustomerId"].ToString(),
                        AcctNumber = readAccount["AccountNumber"].ToString(),
                        Balance = (int)readAccount["Balance"],
                        DateCreated = (DateTime)readAccount["DateCreated"],
                        AccType = readAccount["AccountType"].ToString(),
                        
                    };

                }

            }

            return account;

        }




        /// <summary>
        /// Query to get List of perticular customer account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static  List<Account> GetCustomerAccounts(string id)
        {

            var listOfAccount = new List<Account>();
            Account account;
            using (var connected = Database.GetConnection())
            {
                connected.Open();
            //  var queryAccount = ("SELECT * FROM AccountTable WHERE AccountId = @id");
                SqlCommand _sqlCommand = new SqlCommand("GetCustomerAccounts", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

           //   SqlCommand _sqlCommand = new SqlCommand(queryAccount, connected);
                _sqlCommand.Parameters.AddWithValue("@AccountId", id);

                var readAccount = _sqlCommand.ExecuteReader();

                while (readAccount.Read())
                {


                    account = new Account
                    {
                        CustomerId = readAccount["AccountId"].ToString(),
                        AcctNumber = readAccount["AccountNumber"].ToString(),
                        Balance = Convert.ToInt32(readAccount["Balance"]),
                        DateCreated = Convert.ToDateTime(readAccount["DateCreated"]),
                        AccType = readAccount["AccountType"].ToString(),

                    };

                    listOfAccount.Add(account);

                }

            }

            return listOfAccount;
        }




        /// <summary>
        /// Query to check if a particular account exists
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public static int CheckAccount(string accountNumber)
        {
            int rowcount = 0;

            using (var connected = Database.GetConnection())
            {
                connected.Open();
          //    var queryAccount = ("SELECT COUNT(*) FROM AccountTable WHERE AccountNumber = @accountNumber");
                SqlCommand _sqlCommand = new SqlCommand("CheckAccount", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

           //   SqlCommand _sqlCommand = new SqlCommand(queryAccount, connected);
                _sqlCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                rowcount = (int)_sqlCommand.ExecuteScalar();

            }

            return rowcount;
        }



        /// <summary>
        /// Query to get Account Type
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public static string GetAccountType(String accountNumber)
        {
            string type = string.Empty;
            using (var connected = Database.GetConnection())
            {
                connected.Open();
            //  var queryAccount = ("SELECT AccountType FROM AccountTable WHERE AccountNumber = @accountNumber");
                SqlCommand _sqlCommand = new SqlCommand("GetAccountType", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };


           //   SqlCommand _sqlCommand = new SqlCommand(queryAccount, connected);
                _sqlCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                var readAccount = _sqlCommand.ExecuteReader();

                while (readAccount.Read())
                {

                    type = readAccount["AccountType"].ToString();
                }

            }

            return type.Trim();

        }





        /// <summary>
        /// Query to get balance from database
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public static decimal GetBalance(string accountNumber)
        {
            decimal sum = 0;
            using (var connected = Database.GetConnection())
            {
                connected.Open();
          //    var queryAccount = ("SELECT SUM(Balance) FROM AccountTable WHERE AccountNumber = @accountNumber");
                SqlCommand _sqlCommand = new SqlCommand("GetBalance", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

           //   SqlCommand _sqlCommand = new SqlCommand(queryAccount, connected);
                _sqlCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                sum = Convert.ToInt32(_sqlCommand.ExecuteScalar());
            }

            return sum;
        }


        public static void UpdateAccountBalance(string accountNumber, decimal amount)
        {

            //decimal updatedAmount = 0;
            using var connected = Database.GetConnection();
            connected.Open();
       //   var queryAccount = ("UPDATE AccountTable SET Balance = @amount WHERE AccountNumber = @accountNumber");
            SqlCommand _sqlCommand = new SqlCommand("UpdateAccountBalance", connected)
            {
                CommandType = CommandType.StoredProcedure
            };

       //   SqlCommand _sqlCommand = new SqlCommand(queryAccount, connected);
            _sqlCommand.Parameters.AddWithValue("@Amount", amount);
            _sqlCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

            _sqlCommand.ExecuteScalar();


        }        

    }
}
