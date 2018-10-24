using BankApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DAL.Interface
{
    public interface IUserLoginDataAccess
    {
        UserLogin ValidateCredentials(UserLogin entity);
        void CreateUserLogin(UserLogin entity);
    }
}
