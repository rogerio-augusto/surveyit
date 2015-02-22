using System.Collections.Generic;

namespace SurveyIt.Domain.Contracts.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Create(TEntity obj);
        TEntity Find(int Id);
        IEnumerable<TEntity> FindAll();
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();
    }
}
