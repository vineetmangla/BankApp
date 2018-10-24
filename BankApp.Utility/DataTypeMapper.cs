using AutoMapper;
using BankApp.DomainModel;
using BankApp.DTO;
using BankApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Utility
{
    public class DataTypeMapper
    {
        public static void CreateMap()

        {

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserVM, UserDto>();
                cfg.CreateMap<UserDto,UserVM>();
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserDto,User>();
                cfg.CreateMap<UserLoginVM, UserLoginDTO>();
                cfg.CreateMap<UserLoginDTO, UserLoginVM>();
                cfg.CreateMap<UserLogin, UserLoginDTO>();
                cfg.CreateMap<UserLoginDTO, UserLogin>();
                cfg.CreateMap<AccountVM, AccountDTO>();
                cfg.CreateMap<AccountDTO, AccountVM>();
                cfg.CreateMap<Account, AccountDTO>();
                cfg.CreateMap<AccountDTO, Account>();
                cfg.CreateMap<TransactionVM, TransactionDTO>();
                cfg.CreateMap<TransactionDTO, TransactionVM>();
                cfg.CreateMap<Transactions, TransactionDTO>();
                cfg.CreateMap<TransactionDTO, Transactions>();

            });
            
        }
    }
}
