using Raph.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raph.Core.Interface
{
    public interface ITransactionRepository
    {

        bool AddTransaction(Transaction transaction, string accountNumber);
        int Rowcount();

        Transaction GetTransaction(string accountNumber);

        List<Transaction> GetAllTransaction(string accountNumber);
        decimal GetTransactBalance(string accountNumber);
    }
}
