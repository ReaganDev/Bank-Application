using Raph.Core.Interface;
using Raph.Data;
using Raph.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Raph.Core
{
    public class TransactionRepository : ITransactionRepository
    {
        public int CountRow { get; private set; }

        public TransactionRepository()
        {
            CountRow = DbTransactionOperation.Rowcount();
        }



        #region  DONE
        /// <summary>
        /// adding transaction to database
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public bool AddTransaction(Transaction transaction,string accountNumber)
        {

            //do a row count of your database
            CountRow = DbTransactionOperation.Rowcount();


            //add transction to database
            DbTransactionOperation.AddTransactionQuery(transaction);

            //get Balance in TransactionTable
            var newAmount = DbTransactionOperation.GetTransactionBalance(accountNumber);
            //update amount in account table
            DbAccountOperation.UpdateAccountBalance(accountNumber,newAmount);


            var CountRowAfterAddition = DbTransactionOperation.Rowcount();

            if(CountRow <= CountRowAfterAddition)
            {
                CountRow = CountRowAfterAddition;
                return true;
            }
            
            return false;
        }




        /// <summary>
        /// count transaction row
        /// </summary>
        /// <returns></returns>
        public int Rowcount()
        {
            return DbTransactionOperation.Rowcount();
        }





        /// <summary>
        /// get a single transaction
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public Transaction GetTransaction(string accountNumber)
        {
            var queryTransaction = DbTransactionOperation.GetTransactionByAccountNumber(accountNumber);

            return queryTransaction;
        }



        /// <summary>
        /// get all transaction
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public List<Transaction> GetAllTransaction(string accountNumber)
        {
            var transactionQuery = DbTransactionOperation.GetAllTransaction(accountNumber);

            return transactionQuery;
        }

        #endregion



        /// <summary>
        /// get account balance
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public decimal GetTransactBalance(string accountNumber)
        {
            decimal balance = DbTransactionOperation.GetTransactionBalance(accountNumber);
            return balance;
        }


        #region //NOT DONE

        /// <summary>
        /// remove transaction using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemoveTransaction(string id)
        {
            CountRow = Database.ListOfTransaction.Count;
            foreach (var transaction in Database.ListOfTransaction)
            {
                if (transaction.Id == id)
                {
                    Database.ListOfTransaction.Remove(transaction);
                    var CountRowAfterDeleting = Database.ListOfTransaction.Count;
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