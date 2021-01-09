using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TravelAssist.Model.Contracts;

namespace TravelAssist.BLL.Contracts
{
    public interface IManager<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(IDeletable entity);
        T GetById(int id);
        ICollection<T> GetAll(bool withDeleted = false);
        ICollection<T> Get(Expression<Func<T, bool>> query);
    }
}
