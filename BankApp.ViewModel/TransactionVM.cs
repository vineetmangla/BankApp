using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BankApp.ViewModel
{
    public class TransactionVM
    {
        public IEnumerable<SelectListItem> FromAccount { get; set; }
        public IEnumerable<SelectListItem> ToAccount { get; set; }        
        public long FromAccountId { get; set; }
        public long ToAccountId { get; set; }
        public int Amount { get; set; }



    }
}
