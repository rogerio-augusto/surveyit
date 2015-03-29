using SurveyIt.Core.DomainEntities;
using System;
using System.Collections.Generic;

namespace SurveyIt.Core.Contracts.Services
{
    public interface IHotsiteService : IServiceBase<Hotsite>
    {
        IEnumerable<Hotsite> FindByDeadline(DateTime deadline);
    }
}
