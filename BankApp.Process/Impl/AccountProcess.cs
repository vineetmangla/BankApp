using AutoMapper;
using BankApp.DAL.Interface;
using BankApp.DomainModel;
using BankApp.DTO;
using BankApp.Process.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Process.Impl
{
    public class AccountProcess : IAccountProcess
    {
        private IAccountDataAccess AccountDataAccess = null;
        //public AccountProcess(IAccountDataAccess _accountDataAccess)
        //{
        //    this.AccountDataAccess = _accountDataAccess;
        //}

        private IDataFactory DataFactory = null;
        public AccountProcess(IDataFactory _DataFactory)
        {
            this.DataFactory = _DataFactory;
            AccountDataAccess = DataFactory.GetData<IAccountDataAccess>();
        }
        public void AddAccount(AccountDTO accountDTO)
        {
            AccountDataAccess.Add(Mapper.Map<Account>(accountDTO));

        }

        public IEnumerable<AccountDTO> GetAccountByUserId(long userId)
        {
            return Mapper.Map<IEnumerable<AccountDTO>>(AccountDataAccess.GetAccountByUserId(userId));
        }

        public IEnumerable<AccountDTO> GetLinkedAccountByUserId(long userId)
        {
            return Mapper.Map<IEnumerable<AccountDTO>>(AccountDataAccess.GetLinkedAccountByUserId(userId));
        }

        public AccountDTO SearchByAccount(int accountNumber)
        {
            var accountDto = AccountDataAccess.SearchByAccount(accountNumber);
            return Mapper.Map<AccountDTO>(accountDto);
        }
    }
}
