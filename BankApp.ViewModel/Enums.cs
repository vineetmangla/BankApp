using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.ViewModel
{
    
    public enum UserType
    {
        Customer = 1,
        BankTeller = 2         
    }

    public enum AccountType
    {
        Savings = 1,
        Current = 2,
        FixedDeposit=3
    }
}
