using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DTO
{
    public class UserLoginDTO
    {
        public long LoginId { get; set; }
        public string Password { get; set; }
        public long UserId { get; set; }

        public UserDto User { get; set; }
    }
}
