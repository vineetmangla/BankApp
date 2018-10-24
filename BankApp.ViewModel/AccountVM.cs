using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BankApp.ViewModel
{
    public class AccountVM
    {
        public AccountVM()
        {
            IEnumerable<AccountType> actionTypes = Enum.GetValues(typeof(AccountType))
                                                         .Cast<AccountType>();
            AccountTypeList = from action in actionTypes
                           select new SelectListItem
                           {
                               Text = action.ToString(),
                               Value = ((int)action).ToString()
                           };
        }
        [Required]
        public long AccountNumber { get; set; }

        public int AccountType { get; set; }

        public IEnumerable<SelectListItem> AccountTypeList { get; set; }

        [Required]
        public int UserId { get; set; }

        public long AccountId { get; set; }

        public UserVM User { get; set; }

        public int Balance { get; set; }
    }
}
