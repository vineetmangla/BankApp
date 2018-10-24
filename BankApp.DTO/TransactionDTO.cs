using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DTO
{
    public class TransactionDTO
    {
        public long FromAccountId { get; set; }
        public long ToAccountId { get; set; }
        public int Amount { get; set; }
    }
}
