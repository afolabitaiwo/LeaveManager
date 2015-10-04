using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;


namespace Business.Services.Contexts.Persistence.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> AsQueryable();

        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T Single(Expression<Func<T, bool>> predicate);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
        T First(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        T GetByUniqueId(object id);

        void Add(T entity);
        void Add(ICollection<T> entity);
        int Update(T entity);
        void Update(ICollection<T> entity);


        void AddOrUpdate(T entity);

    }
}