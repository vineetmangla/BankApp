using BankApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Process.Interface
{
    public interface IUserLoginProcess
    {
        UserLoginDTO ValidateCredentials(UserLoginDTO dto);
        void CreateUserLogin(UserLoginDTO dto);
    }
}
