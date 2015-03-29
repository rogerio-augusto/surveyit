using SurveyIt.Core.DomainEntities;
using System;
using System.Collections.Generic;

namespace SurveyIt.Core.Contracts.Repositories
{
    public interface IHotsiteRepository : IRepositoryBase<Hotsite>
    {
        IEnumerable<Hotsite> FindByDeadline(DateTime deadline);
    }
}
