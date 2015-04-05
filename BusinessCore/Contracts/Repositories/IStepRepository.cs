using SurveyIt.Core.DomainEntities;
using System.Collections.Generic;

namespace SurveyIt.Core.Contracts.Repositories
{
    public interface IStepRepository : IRepositoryBase<Step>
    {
        IEnumerable<Step> FindByHotsiteId(int HotsiteId);

        Step FindByHotsiteIdAndStepId(int HotsiteId, int StepId);
    }
}
