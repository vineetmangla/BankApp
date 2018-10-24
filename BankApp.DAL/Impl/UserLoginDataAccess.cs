using BankApp.DAL.Interface;
using BankApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DAL.Impl
{
    public class UserLoginDataAccess : IUserLoginDataAccess
    {
        private IEFRepository<UserLogin, MainDbContext> UserLoginContext = null;
        public UserLoginDataAccess(IEFRepository<UserLogin, MainDbContext> userLoginContext)
        {
            this.UserLoginContext = userLoginContext;
        }
        public void CreateUserLogin(UserLogin entity)
        {
            UserLoginContext.Add(entity);
        }

        public UserLogin ValidateCredentials(UserLogin entity)
        {
            var userDetails = UserLoginContext.Entities.UserLogin.Include("User").Where(x => x.LoginId == entity.LoginId && x.Password == entity.Password).FirstOrDefault();
            return userDetails;
        }
    }
}
