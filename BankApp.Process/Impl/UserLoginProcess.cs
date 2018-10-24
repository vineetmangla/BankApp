using AutoMapper;
using BankApp.DAL.Interface;
using BankApp.DomainModel;
using BankApp.DTO;
using BankApp.Process.Interface;
using BankApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Process.Impl
{
    public class UserLoginProcess : IUserLoginProcess
    {
        private IDataFactory DataFactory = null;
        public UserLoginProcess(IDataFactory _DataFactory)
        {
            this.DataFactory = _DataFactory;
             
        }
        public void CreateUserLogin(UserLoginDTO dto)
        {
            if (dto != null && dto.UserId > 0)
            {
                dto.LoginId = DateTime.Now.Ticks;
                dto.Password = Common.GenerateMD5(dto.LoginId.ToString());
                DataFactory.GetData<IUserLoginDataAccess>().CreateUserLogin(Mapper.Map<UserLogin>(dto));
            }
        }

        public UserLoginDTO ValidateCredentials(UserLoginDTO dto)
        {
            dto.Password = Common.GenerateMD5(dto.Password);
            var userDetails = DataFactory.GetData<IUserLoginDataAccess>().ValidateCredentials(Mapper.Map<UserLogin>(dto));
            return Mapper.Map<UserLoginDTO>(userDetails);
        }
    }
}
