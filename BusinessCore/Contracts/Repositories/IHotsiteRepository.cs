using SurveyIt.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SurveyIt.Domain.Contracts
{
    public interface IHotsiteRepository : IRepositoryBase<Hotsite>
    {
        IEnumerable<Hotsite> FindByDeadline(DateTime deadline);
    }
}
