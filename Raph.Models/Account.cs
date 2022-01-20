using System;
using System.Collections.Generic;
using System.Text;

namespace Raph.Models
{
    public class Account
    {
        private static readonly Random _random = new Random();
        public string AcctNumber { get; set; } = " 306425" + _random.Next(1234, 7866);
        public string CustomerId { get; set; }
        public virtual string AccType { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public decimal Balance { get; set; }

        public ICollection<Transaction> TransactHistory { get; set; }

        public Account()
        { 
            TransactHistory = new HashSet<Transaction>();
          
        }
        public Account(string id, string accountType, decimal bal) : this()
        {   
            AccType = accountType;
            CustomerId = id;
            Balance = bal;   
        }

      
       

        
       

    }
}
