using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.ViewModel
{
    public class UserLoginVM
    {
        [Required]
        public long LoginId { get; set; }

        [Required]
        public string Password { get; set; }
        
        public string Message { get; set; }

        public string ReturnUrl { get; set; }
    }
}
