using GenericRepositoryUoW1.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUoW1.Infrastructure
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
          where T : BaseEntity
    {
        protected DbContext entities;
        protected readonly IDbSet<T> dbset;

        public GenericRepository(DbContext context)
        {
            this.entities = context;
            this.dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {

            return this.dbset.AsEnumerable<T>();
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IEnumerable<T> query = this.dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual T Add(T entity)
        {
            return this.dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return this.dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            this.entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public virtual void Save()
        {
            this.entities.SaveChanges();
        }
    }
}
