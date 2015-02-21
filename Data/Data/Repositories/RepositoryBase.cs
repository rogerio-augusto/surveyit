using SurveyIt.Domain.Contracts;
using SurveyIt.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SurveyIt.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected SurveyItDBContext dataContext;

        public RepositoryBase()
        {
            this.dataContext = new SurveyItDBContext();
        }

        public void Create(TEntity obj)
        {
            dataContext.Set<TEntity>().Add(obj);
            dataContext.SaveChanges();
        }

        public TEntity Find(int Id)
        {
            return dataContext.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return dataContext.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            dataContext.Set<TEntity>().Remove(obj);
            dataContext.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
