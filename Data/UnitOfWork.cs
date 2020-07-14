using Concrats;
using Data.Models.Context;
using Domain.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Domain
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private MonitContext Context;

        protected UnitOfWork()
        {
            Context = new MonitContext();
        }
        public void Add(T entity)
        {
            Context.Add(entity);
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            Context.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Find(predicate);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            return Context.Set<T>().Where(predicate);
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
