using Raph.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raph.Core
{
    public static class GlobalConfig
    {

        public static IAuthenticationRepository IAuthRepo { get; private set; }

        public static ICustomerRepository ICustRepo { get; private set; }

        public static IAccountRepository IAccountRepo { get; private set; }

        public static ITransactionRepository ITransactRepo { get; private set; }


        public static void AddInstance()
        {
            IAuthRepo = new AuthenticationRepository();
            ICustRepo = new CustomerRespository();
            IAccountRepo = new AccountRepository();
            ITransactRepo = new TransactionRepository();

        }

        public static void RemoveInstance()
        {
            IAccountRepo = null;
            IAuthRepo = null;
            ICustRepo = null;
            ITransactRepo = null;
        }
    }
}
