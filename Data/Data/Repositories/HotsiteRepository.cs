using SurveyIt.Domain.Contracts;
using SurveyIt.Domain.Entities;
using System;
using System.Linq;
using System.Collections.Generic;

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
