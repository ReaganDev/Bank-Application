using System;
using System.Collections.Generic;
using System.Text;

namespace Raph.Models
{
    public class Transaction
    {
        public string AcctNumber { get; set; }

        public string Id { get; set; }

        public decimal Amount { get; set; }
        public string Remark { get; set; }

        public string AccountType { get; set; }

        public DateTime DateOfTransaction { get; set; }


        public Transaction()
        {
            DateOfTransaction = DateTime.Now;
            Id = Guid.NewGuid().ToString();
        }

        public Transaction(string acctNum, string acctType, decimal amount, string remark) : this()
        {
            Amount = amount;
            Remark = remark;
            AcctNumber = acctNum;
            AccountType = acctType;

        }
    }
}
