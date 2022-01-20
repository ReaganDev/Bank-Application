using Raph.Core.Interface;
using Raph.Data;
using Raph.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Raph.Core
{
    public class AccountRepository : IAccountRepository
    {
        private readonly TransactionRepository _transactionRepository;
        public int CountRow { get; private set; }

        public AccountRepository()
        {
            _transactionRepository = new TransactionRepository();
            CountRow = DbAccountOperation.Rowcount();
        }

        /// <summary>
        /// Add account using model
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>

        public bool AddAccount(Account account)
        {
            // do a row count of your database
            CountRow = DbAccountOperation.Rowcount();


            //add account to your database
            DbAccountOperation.AddAccountQuery(account);


            foreach (var transaction in account.TransactHistory)
            {
                _transactionRepository.AddTransaction(transaction,transaction.AcctNumber);
            }

            //do a count after addition
            var CountRowAfterAddition = DbAccountOperation.Rowcount(); 

             if (CountRow >= CountRowAfterAddition)
             {
                return false;

             }

            CountRow = CountRowAfterAddition;

            return true;
        }




        /// <summary>
        /// get Account by account Number
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        
        public Account GetAccountByAccountNumber(string accountNumber)
        {
            var accountQuery = DbAccountOperation.GetAccountByAccountNumber(accountNumber);
            return accountQuery;
        }
        /// <summary>
        /// get customer Accounts using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         
        public List<Account> GetCustomerAccounts(string id)
        {

            var accountQuery = DbAccountOperation.GetCustomerAccounts(id);

            return accountQuery;
          
        }

        /// <summary>
        /// check if account number exist
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        
        public bool NumExist(string accountNumber)  
        {
            var accountQuery = DbAccountOperation.CheckAccount(accountNumber);

            bool flag;
            if (accountQuery > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// Get account Type
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public string AccountType(string accountNumber)
        {
            
            var typeQuery = DbAccountOperation.GetAccountType(accountNumber);
           
            return typeQuery;
        }

        /// <summary>
        /// get account balance
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public decimal GetBalance(string accountNumber)
        {
            decimal balance = DbAccountOperation.GetBalance(accountNumber);
            return balance;
        }
        /// <summary>
        /// Make Deposit
        /// </summary>
        /// <param name="accountNum"></param>
        /// <param name="accountType"></param>
        /// <param name="amount"></param>
        /// <param name="remark"></param>
        public void Deposit(string accountNum,string accountType, decimal amount, string remark)
        {
            if(amount< 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit must be positive");
            }

            var initialCount = _transactionRepository.Rowcount();

            Transaction deposit = new Transaction(accountNum, accountType, amount, remark);
            _transactionRepository.AddTransaction(deposit,accountNum);

            var aftercount = _transactionRepository.Rowcount();

            if(initialCount >= aftercount)
            {
                throw new Exception("Failed to add transaction");
            }


        }

        /// <summary>
        /// make Withdrawal
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="accountType"></param>
        /// <param name="amount"></param>
        /// <param name="remark"></param>
        public void Withdraw(string accountNumber,string accountType, decimal amount, string remark)
        {
             if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be Positive ");
            }

            var bal = GetBalance(accountNumber);

            if (accountType == "Savings")
            {
                if (bal <= 1000 || bal < amount)
                {
                    MessageBox.Show("Insufficient Fund. Your Balance is :" + bal, "Balance", MessageBoxButtons.OK);
                }
                else if(bal >= (amount + 1000))
                {
                    Transaction withdraw = new Transaction(accountNumber, accountType, -amount, remark);
                    _transactionRepository.AddTransaction(withdraw,accountNumber);
                }
                else
                {
                    MessageBox.Show("Invalid Transaction");
                }
            }   
            else if (accountType == "Current")
            {
                if (bal == 0 || bal < amount)
                {
                    MessageBox.Show("Insufficient Fund. Your Balance is :" + bal, "Balance", MessageBoxButtons.OK);
                }
                else if (bal >= amount)
                {
                    Transaction withdraw = new Transaction(accountNumber, accountType, -amount, remark);
                    _transactionRepository.AddTransaction(withdraw,accountNumber);
                }
                else
                {
                    MessageBox.Show("Invalid Transaction");
                }

            }
        }

        /// <summary>
        /// fund transfer
        /// </summary>
        /// <param name="senderAccNum"></param>
        /// <param name="recieverAccNum"></param>
        /// <param name="amount"></param>
        /// <param name="accType"></param>
        /// <param name="remark"></param>
        public void FundTransfer(string senderAccNum, string recieverAccNum, decimal amount, string remark)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be Positive");
            }

            if (!NumExist(recieverAccNum))
            {
                throw new InvalidOperationException("The Receiver Number is not Recognized!");
            }

            if(senderAccNum == recieverAccNum)
            {
                throw new InvalidOperationException("Cannot Transfer within the same Account");
            }

            var sendertype = AccountType(senderAccNum);
            var receivertype = AccountType(recieverAccNum);

            Withdraw(senderAccNum, sendertype, amount, remark);
            Deposit(recieverAccNum, receivertype, amount, remark);

     
        }

        #region // NOT DONE
        /// <summary>
        /// remove account using account
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>

        public bool RemoveAccount(String accountNumber)
        {
            CountRow = Database.ListOfAccount.Count;
            foreach (var account in Database.ListOfAccount)
            {
                if (account.AcctNumber == accountNumber)
                {
                    Database.ListOfAccount.Remove(account);
                    var CountRowAfterDeleting = Database.ListOfAccount.Count;

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
