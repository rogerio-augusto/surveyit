using System.Collections.Generic;

namespace SurveyIt.Core.Contracts.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Create(TEntity obj);
        TEntity Find(int Id);
        IEnumerable<TEntity> FindAll();
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();
    }
}
