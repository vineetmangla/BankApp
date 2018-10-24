using BankApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DAL
{
    public class MainDbContext:DbContext 
    {
        public MainDbContext() : base("name=BankDbConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }

    }
}
