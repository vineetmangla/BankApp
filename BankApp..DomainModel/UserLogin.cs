using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DomainModel
{
    public class UserLogin:BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public long LoginId { get; set; }
        public string Password { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

    }
}
