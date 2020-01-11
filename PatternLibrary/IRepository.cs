using System;
using System.Collections.Generic;

namespace PatternLibrary
{
    public interface IRepository<T> 
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetWhere(Func<T, bool> predicate);
        IRepository<T> Add(T entity);
        IRepository<T> Delete(T entity);
        IRepository<T> Delete(int id);
        IRepository<T> Update(T entity);
    }
}
