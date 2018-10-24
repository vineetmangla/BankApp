using BankApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DAL.Interface
{
    public interface IEFRepository<T,V> where T: BaseEntity
    {
        V Entities { get; }
        
        void Add(T entity);
        IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

        IQueryable<T> GetAll();

        IQueryable<T> ExecuteSql(string sql, object[] parameters);

        //string GetActualQuery();
    }
}
