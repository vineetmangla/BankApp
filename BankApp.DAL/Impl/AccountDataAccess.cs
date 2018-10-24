using BankApp.DomainModel;
using BankApp.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankApp.DAL.Impl
{
    public class AccountDataAccess : IAccountDataAccess
    {
        private IEFRepository<Account,MainDbContext> _accountRepository;
        public AccountDataAccess(IEFRepository<Account, MainDbContext> accountRepository)
        {
            this._accountRepository = accountRepository;
        }       

        public void Add(Account account)
        {
            _accountRepository.Add(account);
        }

        public IEnumerable<Account> GetAccountByUserId(long userId)
        {
            return _accountRepository.FindBy(x => x.UserId == userId);
        }

        public IEnumerable<Account> GetLinkedAccountByUserId(long userId)
        {
            return _accountRepository.FindBy(x => x.UserId != userId).Take(10);
        }

        public Account SearchByAccount(int accountNumber)
        {
            Account account = null;
            //var account = _accountRepository.FindBy(acct => acct.AccountNumber == accountNumber).FirstOrDefault();
            //using (var sqlLogFile = new StreamWriter("D:\\Assignments\\log\\sqlLogFile.txt"))
            //{                
                //_accountRepository.Entities.Database.Log = sqlLogFile.Write;

                 account = _accountRepository.Entities.Account.Include("User").Where(acct => acct.AccountNumber == accountNumber).FirstOrDefault();
                //account = _accountRepository.FindBy(acct => acct.AccountNumber == accountNumber).FirstOrDefault();
               // var user = account.User;
            //}
           // string query = _accountRepository.GetActualQuery();
            return account;
        }
    }
}
