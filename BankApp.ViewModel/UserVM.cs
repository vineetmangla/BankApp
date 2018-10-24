using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BankApp.ViewModel
{
    public class UserVM
    {
        public UserVM()
        {
          IEnumerable<UserType> actionTypes = Enum.GetValues(typeof(UserType))
                                                       .Cast<UserType>();
            UserTypeList = from action in actionTypes
                                select new SelectListItem
                                {
                                    Text = action.ToString(),
                                    Value = ((int)action).ToString()
                                };
        }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]        
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]

        public string Email { get; set; }

        public int UserType { get; set; }

        public IEnumerable<SelectListItem> UserTypeList { get; set; }

        public int UserId { get; set; }


    }
}
