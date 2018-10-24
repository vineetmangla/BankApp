using BankApp.DAL.Interface;
using BankApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DAL.Impl
{
    public class EFRepository<T,V> : IEFRepository<T,V> where T : BaseEntity where V:DbContext
    {
       // private DbContext _context;
        private IDbSet<T> _dbset;
       



        public EFRepository(V context)
        {
            this.Entities = context;
            _dbset = context.Set<T>();
           
        }

        public V Entities { get; set; }

        public void Add(T entity)
        {
            _dbset.Add(entity);
            Entities.SaveChanges();
        }

        public IQueryable<T> ExecuteSql(string sql,object[] parameters)
        {
            return Entities.Database.SqlQuery<T>(sql, parameters).AsQueryable();
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _dbset.Where(predicate).AsQueryable();
            
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _dbset.AsQueryable();
            return query;
        }

        //public string GetActualQuery()
        //{
        //    return _context.Database.Log.ToString();
        //}
    }
}
