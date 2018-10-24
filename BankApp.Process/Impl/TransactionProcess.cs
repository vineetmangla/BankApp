using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BankApp.DAL.Interface;
using BankApp.DomainModel;
using BankApp.DTO;

namespace BankApp.Process.Impl
{
    public class TransactionProcess : ITransactionProcess
    {
        private ITransactionDataAccess TransactionDataAccess = null;
        public TransactionProcess(ITransactionDataAccess _transactionDataAccess)
        {
            this.TransactionDataAccess = _transactionDataAccess;
        }
        public void CreateTransactiion(TransactionDTO transactionDto)
        {
            TransactionDataAccess.Add(Mapper.Map<Transactions>(transactionDto));
        }
    }
}
