using SurveyIt.Domain.Contracts;
using SurveyIt.Domain.Contracts.Services;
using SurveyIt.Domain.Entities;

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
