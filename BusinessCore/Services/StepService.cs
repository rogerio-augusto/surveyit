using SurveyIt.Core.Contracts.Repositories;
using SurveyIt.Core.Contracts.Services;
using SurveyIt.Core.DomainEntities;
using System.Collections.Generic;

namespace SurveyIt.Core.Services
{
    public class StepService : ServiceBase<Step>, IStepService
    {
        private readonly IStepRepository stepRepository;

        public StepService(IStepRepository stepRepository)
            : base(stepRepository)
        {
            this.stepRepository = stepRepository;
        }

        public IEnumerable<Step> FindByHotsiteId(int HotsiteId)
        {
            return stepRepository.FindByHotsiteId(HotsiteId);
        }

        public Step FindByHotsiteIdAndStepId(int HotsiteId, int StepId)
        {
            return stepRepository.FindByHotsiteIdAndStepId(HotsiteId, StepId);
        }
    }
}
