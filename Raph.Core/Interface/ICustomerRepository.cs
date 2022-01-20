using Raph.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raph.Core.Interface
{
    public interface ICustomerRepository
    {
        bool AddUser(Customer customer);
        bool AddAccount(Account account);
        int RowCount();

        Customer GetCustomerById(string id);

        Customer GetCustomerByEmail(string email);
    }
}
