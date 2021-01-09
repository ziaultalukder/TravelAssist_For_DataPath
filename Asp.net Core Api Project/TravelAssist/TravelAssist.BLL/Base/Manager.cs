using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TravelAssist.Model.Contracts;
using TravelAssist.Repository.Contracts;

namespace TravelAssist.BLL.Base
{
    public abstract class Manager<T> where T: class
    {
        private readonly IRepository<T> repository;

        public Manager(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public virtual bool Add(T entity)
        {
            return repository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return repository.Update(entity);
        }

        public virtual bool Remove(IDeletable entity)
        {
            bool IsDeletable = entity is IDeletable;
            if (!IsDeletable)
            {
                throw new Exception("This Item Is Not Deletable");
            }
            return repository.Remove((IDeletable)entity);
        }

        public virtual T GetById(int id)
        {
            return repository.GetById(id);
        }

        public virtual ICollection<T> GetAll(bool withDeleted = false)
        {
            return repository.GetAll(withDeleted);
        }

        public virtual ICollection<T> Get(Expression<Func<T, bool>> query)
        {
            return repository.Get(query);
        }
    }
}
