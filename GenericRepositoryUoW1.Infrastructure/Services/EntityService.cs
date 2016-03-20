using GenericRepositoryUoW1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUoW1.Infrastructure.Services
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        IUnitOfWork unitOfWork;
        IGenericRepository<T> repository;

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            this.unitOfWork = unitOfWork;
            this.repository = repository;
        }


        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.repository.Add(entity);
            this.unitOfWork.Commit();
        }


        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            this.repository.Edit(entity);
            this.unitOfWork.Commit();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            this.repository.Delete(entity);
            this.unitOfWork.Commit();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return this.repository.GetAll();
        }
    }
}
