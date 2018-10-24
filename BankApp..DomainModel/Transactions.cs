using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DomainModel
{
    public class Transactions:BaseEntity
    {
        [Key]    
        public long TransactionId { get; set; }
        public long FromAccountId { get; set; }
        public long ToAccountId { get; set; }

        public int Amount { get; set; }
    }
}
