using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyIt.Domain.Contracts
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
