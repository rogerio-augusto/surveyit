using SurveyIt.Core.Contracts.Repositories;
using SurveyIt.Core.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SurveyIt.Infra.Data.Repositories
{
    public class HotsiteRepository : RepositoryBase<Hotsite>, IHotsiteRepository
    {
        public IEnumerable<Hotsite> FindByDeadline(DateTime deadline)
        {
            return dataContext.Hotsites.Where(h => h.Deadline == deadline);
        }
    }
}
