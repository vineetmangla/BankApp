using BankApp.DAL.Interface;
using BankApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DAL.Impl
{
    public class TransactionDataAccess : ITransactionDataAccess
    {
        private IEFRepository<Transactions, MainDbContext> TransactionContext = null;
        public TransactionDataAccess(IEFRepository<Transactions, MainDbContext> transactionContext)
        {
            this.TransactionContext = transactionContext;
        }
        public void Add(Transactions transaction)
        {
           var output = TransactionContext.ExecuteSql("exec dbo.[prc_funds_transfer] @FromAccountId,@ToAccountId,@Amount",
                new object[] { new SqlParameter("@FromAccountId",transaction.FromAccountId),
                new SqlParameter("@ToAccountId",transaction.ToAccountId),
                new SqlParameter("@Amount",transaction.Amount)
                });
            var itr =  output.FirstOrDefault();
        }
    }
}
