using AutoMapper;
using BankApp.DAL.Interface;
using BankApp.DomainModel;
using BankApp.DTO;
using BankApp.Process.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Process
{
    public class UserProcess : IUserProcess
    {
        private IDataFactory DataFactory = null;
        private IProcessFactory ProcessFactory = null;

        public UserProcess(IDataFactory _DataFactory, IProcessFactory _ProcessFactory)
        {
            this.DataFactory = _DataFactory;
            this.ProcessFactory = _ProcessFactory;
        }
        public void AddUser(UserDto userDto)
        {
            User user =  DataFactory.GetData<IUserDataAccess>().Add(Mapper.Map<User>(userDto));
            if(user!=null && user.UserId>0)
            {
                UserLoginDTO loginDto = new UserLoginDTO();
                loginDto.UserId = user.UserId;
                ProcessFactory.GetProcessFactory<IUserLoginProcess>().CreateUserLogin(loginDto);
            }

        }

        public IEnumerable<UserDto> GetAll()
        {
            var user = DataFactory.GetData<IUserDataAccess>().GetAllUser();
            return Mapper.Map<IEnumerable<UserDto>>(user);
        }
    }
}
