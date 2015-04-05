using SurveyIt.Core.Contracts.Repositories;
using SurveyIt.Core.Contracts.Services;
using SurveyIt.Core.DomainEntities;
using System;
using System.Collections.Generic;

namespace SurveyIt.Core.Services
{
    public class HotsiteService : ServiceBase<Hotsite>, IHotsiteService
    {
        private readonly IHotsiteRepository hotsiteRepository;

        public HotsiteService(IHotsiteRepository hotsiteRepository)
            : base(hotsiteRepository)
        {
            this.hotsiteRepository = hotsiteRepository;
        }

        public IEnumerable<Hotsite> FindByDeadline(DateTime deadline)
        {
            return this.hotsiteRepository.FindByDeadline(deadline);
        }
    }
}
