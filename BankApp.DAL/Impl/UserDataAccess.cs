using BankApp.DomainModel;
using BankApp.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DAL.Impl
{
    public class UserDataAccess: IUserDataAccess
    {
        private IEFRepository<User, MainDbContext> _usersRepository;
        public UserDataAccess(IEFRepository<User, MainDbContext> usersRepository)
        {
            this._usersRepository = usersRepository;
        }
        public User Add(User model)
        {
            _usersRepository.Add(model);
            return model;
        }

        public IEnumerable<User> GetAllUser()
        {
            return _usersRepository.GetAll().ToList();
        }
    }
}
