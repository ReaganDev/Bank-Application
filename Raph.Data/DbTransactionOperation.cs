using Raph.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace Raph.Data
{
    public class DbTransactionOperation
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
              //var queryTransaction = ("SELECT COUNT(*) FROM TransactionTable");
                SqlCommand _sqlCommand = new SqlCommand("CountRowInTransactionTable", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

             // SqlCommand _sqlCommand = new SqlCommand(queryTransaction, connected);

                rowcount = (int)_sqlCommand.ExecuteScalar();

            }

            return rowcount;
        }



        /// <summary>
        /// Query to add account to database
        /// </summary>
        /// <param name="transaction"></param>
        public static void AddTransactionQuery(Transaction transaction)
        {
            using var connected = Database.GetConnection();
            connected.Open();

         // var queryTransaction = "INSERT INTO TransactionTable VALUES(@TransactionId, @AccountNumber, @AccountType,@Amount,@Remark,@DateOfTransaction)";
            SqlCommand _sqlCommand = new SqlCommand("AddTransactionQuery", connected)
            {
                CommandType = CommandType.StoredProcedure
            };

        //  SqlCommand _sqlCommand = new SqlCommand(queryTransaction, connected);
            _sqlCommand.Parameters.AddWithValue("@TransactionId", transaction.Id);
            _sqlCommand.Parameters.AddWithValue("@AccountNumber", transaction.AcctNumber);
            _sqlCommand.Parameters.AddWithValue("@AccountType", transaction.AccountType);
            _sqlCommand.Parameters.AddWithValue("@Amount", transaction.Amount);
            _sqlCommand.Parameters.AddWithValue("@Remark", transaction.Remark);
            _sqlCommand.Parameters.AddWithValue("@DateOfTransaction", transaction.DateOfTransaction);

            _sqlCommand.ExecuteNonQuery();

        }



        /// <summary>
        /// Query to get a transaction
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public static Transaction GetTransactionByAccountNumber(string accountNumber)
        {
            Transaction transaction = null;
            using (var connected = Database.GetConnection())
            {
                connected.Open();
            //  var queryTransaction = ("SELECT * FROM TransactionTable WHERE AccountNumber = @AccountNumber");

                SqlCommand _sqlCommand = new SqlCommand("GetTransactionByAccountNumber", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

             // SqlCommand _sqlCommand = new SqlCommand(queryTransaction, connected);
                _sqlCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                var readTransaction = _sqlCommand.ExecuteReader();

                while (readTransaction.Read())
                {


                    transaction = new Transaction
                    {
                        Id = readTransaction["TransactionId"].ToString(),
                        AcctNumber = readTransaction["AccountNumber"].ToString(),
                        Amount = (int)readTransaction["Amount"],
                        Remark = readTransaction["Remark"].ToString(),
                        AccountType = readTransaction["AccountType"].ToString(),
                        DateOfTransaction = (DateTime)readTransaction["DateOfTransaction"]

                    };

                }

            }

            return transaction;
        }




        /// <summary>
        /// Query to get List of perticular 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Transaction> GetAllTransaction(string accountNumber)
        {

            var listOfTransaction = new List<Transaction>();
            using (var connected = Database.GetConnection())
            {
                connected.Open();
            //  var queryTransaction = ("SELECT AccountNumber,Amount,DateOfTransaction,AccountType,Remark FROM TransactionTable WHERE AccountNumber = @AccountNumber");
                SqlCommand _sqlCommand = new SqlCommand("GetAllTransaction", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

            //  SqlCommand _sqlCommand = new SqlCommand(queryTransaction, connected);
                _sqlCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                var readTransaction = _sqlCommand.ExecuteReader();

                while (readTransaction.Read())
                {


                    Transaction transaction = new Transaction
                    {
                        //Id = readTransaction["TransactionId"].ToString(),
                        AcctNumber = readTransaction["AccountNumber"].ToString(),
                        Amount = Convert.ToInt32(readTransaction["Amount"]),
                        DateOfTransaction = Convert.ToDateTime(readTransaction["DateOfTransaction"]),
                        AccountType = readTransaction["AccountType"].ToString(),
                        Remark = readTransaction["Remark"].ToString()

                    };

                    listOfTransaction.Add(transaction);

                }

            }

            return listOfTransaction;
        }



        /// <summary>
        /// get transaction balance
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public static decimal GetTransactionBalance(string accountNumber)
        {

            decimal sum = 0;
            using (var connected = Database.GetConnection())
            {
                connected.Open();
           //   var queryAccount = ("SELECT SUM(Amount) FROM TransactionTable WHERE AccountNumber = @AccountNumber");
                SqlCommand _sqlCommand = new SqlCommand("GetTransactionBalance", connected)
                {
                    CommandType = CommandType.StoredProcedure
                };

           //   SqlCommand _sqlCommand = new SqlCommand(queryAccount, connected);
                _sqlCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                sum = Convert.ToInt32(_sqlCommand.ExecuteScalar());
            }

            return sum;
        }


    }
}
