using BankApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DAL.Interface
{
    public interface IAccountDataAccess
    {
        void Add(Account account);
        Account SearchByAccount(int accountNumber);

        IEnumerable<Account> GetAccountByUserId(long userId);

        IEnumerable<Account> GetLinkedAccountByUserId(long userId);
    }
}
