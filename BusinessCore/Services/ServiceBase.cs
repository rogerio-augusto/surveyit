using SurveyIt.Core.Contracts.Repositories;
using SurveyIt.Core.Contracts.Services;
using System;
using System.Collections.Generic;

namespace SurveyIt.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Create(TEntity obj)
        {
            this.repository.Create(obj);
        }

        public TEntity Find(int Id)
        {
            return this.repository.Find(Id);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return this.repository.FindAll();
        }

        public void Update(TEntity obj)
        {
            this.repository.Update(obj);
        }

        public void Delete(TEntity obj)
        {
            this.repository.Delete(obj);
        }

        public void Dispose()
        {
            this.repository.Dispose();
        }
    }
}
