using BankApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Process
{
    public interface ITransactionProcess
    {
        void CreateTransactiion(TransactionDTO transactionDto);
    }
}
