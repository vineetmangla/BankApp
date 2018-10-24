using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DTO
{
    public class AccountDTO
    {
        
        public long AccountNumber { get; set; }

        
        public int AccountType { get; set; }        

        
        public int UserId { get; set; }

        public long AccountId { get; set; }
        public int Balance { get; set; }

    }
}
