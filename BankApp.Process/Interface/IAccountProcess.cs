using BankApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Process.Interface
{
    public interface IAccountProcess
    {
        void AddAccount(AccountDTO accountDTO);

        AccountDTO SearchByAccount(int accountNumber);
        IEnumerable<AccountDTO> GetAccountByUserId(long userId);

        IEnumerable<AccountDTO> GetLinkedAccountByUserId(long userId);
    }
}
