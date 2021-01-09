using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TravelAssist.Model.Contracts;

namespace TravelAssist.Repository.Contracts
{
    public interface IRepository<T> where T : class 
    {
        T GetById(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(IDeletable entity);        
        ICollection<T> GetAll(bool withDeleted = false);
        ICollection<T> Get(Expression<Func<T, bool>> query);
    }
}
