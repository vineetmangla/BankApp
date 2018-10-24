using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DomainModel
{
    public class Account:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AccountId { get; set; }
        public long AccountNumber { get; set; }
        public int AccountType { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public int Balance { get; set; }
        public User User { get; set; }
    }
}
