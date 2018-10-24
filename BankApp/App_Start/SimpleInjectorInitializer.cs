[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BankApp.App_Start.SimpleInjectorInitializer), "Initialize")]



namespace BankApp.App_Start
{
    using BankApp.DAL;
    using BankApp.DAL.Impl;
    using BankApp.DAL.Interface;
    using BankApp.Process;
    using BankApp.Process.Impl;
    using BankApp.Process.Interface;
    using CommonServiceLocator;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;

    public class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            // Create the container as usual.
            var container = new Container();
            ServiceLocator.SetLocatorProvider(() => new SimpleInjectorServiceLocatorAdapter(container));
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Register your types, for instance:
            InitializeContainer(container);

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<IUserProcess, UserProcess>();
            container.Register<IUserLoginProcess, UserLoginProcess>();

            container.Register<IUserDataAccess, UserDataAccess>();
            container.Register<IUserLoginDataAccess, UserLoginDataAccess>();
            container.Register<IAccountProcess, AccountProcess>();
            container.Register<IProcessFactory, ProcessFactory>();
            container.Register<IDataFactory, DataFactory>();
            
            container.Register<IAccountDataAccess, AccountDataAccess>();
            container.Register<ITransactionProcess, TransactionProcess>();
            container.Register<ITransactionDataAccess, TransactionDataAccess>();
            container.Register<MainDbContext>(() => new MainDbContext(), Lifestyle.Scoped);
            container.Register<DbContext>(() => container.GetInstance<MainDbContext>(), Lifestyle.Scoped);
            container.Register(typeof(IEFRepository<,>), typeof(EFRepository<,>), Lifestyle.Scoped);
            //container.Register<DbContext, MainDbContext>();
            //container.Register(typeof(IEFRepository<,>), typeof(EFRepository<,>));
        }
    }

    public class SimpleInjectorServiceLocatorAdapter : IServiceLocator
    {
        private Container container = null;

        public SimpleInjectorServiceLocatorAdapter(Container container)
        {
            this.container = container;
        }
        public IEnumerable<object> GetAllInstances(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TService> GetAllInstances<TService>()
        {
            throw new NotImplementedException();
        }

        public object GetInstance(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public object GetInstance(Type serviceType, string key)
        {
            throw new NotImplementedException();
        }

        public TService GetInstance<TService>()
        {
            return (TService)container.GetInstance(typeof(TService));
        }

        public TService GetInstance<TService>(string key)
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}