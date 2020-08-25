using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExMessengerApi.Data.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> @where)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> @where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> @where)
        {
            throw new NotImplementedException();
        }
    }
}