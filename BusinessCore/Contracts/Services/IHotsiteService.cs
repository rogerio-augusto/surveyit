using SurveyIt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyIt.Domain.Contracts.Services
{
    public interface IHotsiteService : IServiceBase<Hotsite>
    {
        IEnumerable<Hotsite> FindByDeadline(DateTime deadline);
    }
}
