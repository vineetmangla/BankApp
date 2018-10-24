using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Process
{
    public interface IUserProcess
    {
        void AddUser(UserDto userDto);
        IEnumerable<UserDto> GetAll();
    }
}
