using SurveyIt.Domain.Contracts;
using SurveyIt.Domain.Contracts.Services;
using SurveyIt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyIt.Domain.Services
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
