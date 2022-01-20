using Raph.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raph.Core.Interface
{
    public interface IAccountRepository
    {
        bool AddAccount(Account account);

        Account GetAccountByAccountNumber(string accountNumber);

        List<Account> GetCustomerAccounts(string id);
        bool NumExist(string accountNumber);

        string AccountType(string accountNumber);

        decimal GetBalance(string accountNumber);

        void Deposit(string accountNum, string accountType, decimal amount, string remark);

        void Withdraw(string accountNumber, string accountType, decimal amount, string remark);

        void FundTransfer(string senderAccNum, string recieverAccNum, decimal amount, string remark);
    }
}
