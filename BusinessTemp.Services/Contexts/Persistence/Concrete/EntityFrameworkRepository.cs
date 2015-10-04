using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity.Migrations;
using Business.Services.Contexts.Persistence.Interfaces;

namespace Business.Services.Contexts.Persistence.Concrete
{
    public class EntityFrameworkRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly DbContext _db;


        /// <summary>
        ///Note: This method is most useful when seeding data using Migrations.
        /// </summary>
        /// <param name="entity"></param>
        public void AddOrUpdate(T entity)
        {
            //_dbSet..Add(entity);

            _db.Set<T>().AddOrUpdate(entity);
        }

        public EntityFrameworkRepository(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        public EntityFrameworkRepository(DbContext dbCon)
        {
            _db = dbCon;
        }

        #region IGenericRepository<T> interface contract implementation

        public virtual IQueryable<T> AsQueryable()
        {
            return _db.Set<T>().AsQueryable();
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>();
            //return _dbSet;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate);
            //return _dbSet.Where(predicate);
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            //return _dbSet.Single(predicate);
            return _db.Set<T>().Single(predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            //return _dbSet.SingleOrDefault(predicate);
            return _db.Set<T>().SingleOrDefault(predicate);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            //return _dbSet.First(predicate);
            return _db.Set<T>().First(predicate);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            //return _dbSet.FirstOrDefault(predicate);
            return _db.Set<T>().FirstOrDefault(predicate);
        }

        public T GetByUniqueId(object id)
        {
            //return _dbSet.Find(new object[] { id });
            return _db.Set<T>().Find(new object[] { id });
        }

        public void Add(T entity)
        {
            //_dbSet.Add(entity);
            _db.Set<T>().Add(entity);
        }

        public void Add(ICollection<T> entity)
        {
            //_dbSet.Add(entity);
            foreach (var t in entity)
                _db.Set<T>().Add(t);
        }
        public void Update(ICollection<T> entity)
        {
            foreach (var t in entity)
                _db.Entry(t).State = System.Data.Entity.EntityState.Modified;

        }
        public int Update(T entity)
        {
            _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges();
        }
        /// To do: implement delete as soft delete. Probably as an extension method
        /// 
        //void Delete(T entity);

        //void Attach(T entity);
        #endregion
    }
}