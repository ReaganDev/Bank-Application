using Raph.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raph.Core.Interface
{
    public interface IAuthenticationRepository
    {

        bool IsValidCredential(string email, string password);
        bool Register(Customer customer);
        bool EmailExist(string email);
    }
}
