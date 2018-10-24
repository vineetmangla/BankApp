using BankApp.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DAL.Impl
{
    public class DataFactory: IDataFactory
    {
        public T GetData<T>()
        {
            return CommonServiceLocator.ServiceLocator.Current.GetInstance<T>();
        }        
    }
}
