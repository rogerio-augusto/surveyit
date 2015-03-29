using SurveyIt.Core.Contracts.Repositories;
using SurveyIt.Core.Contracts.Services;
using SurveyIt.Core.DomainEntities;

namespace SurveyIt.Domain.Services
{
    public class StepService : ServiceBase<Step>, IStepService
    {
        private readonly IStepRepository stepRepository;

        public StepService(IStepRepository stepRepository)
            : base(stepRepository)
        {
            this.stepRepository = stepRepository;
        }
    }
}
