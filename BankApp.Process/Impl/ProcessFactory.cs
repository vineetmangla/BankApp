using BankApp.Process.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Process.Impl
{
    public class ProcessFactory: IProcessFactory
    {        
        public T GetProcessFactory<T>()
        {
            return CommonServiceLocator.ServiceLocator.Current.GetInstance<T>();
        }
    }
}
