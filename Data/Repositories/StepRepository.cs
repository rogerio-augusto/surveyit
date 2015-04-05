using SurveyIt.Core.Contracts.Repositories;
using SurveyIt.Core.DomainEntities;
using SurveyIt.Infra.Data.Contexts;
using SurveyIt.Infra.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SurveyIt.Data.Repositories
{
    public class StepRepository : RepositoryBase<Step>, IStepRepository
    {
        public StepRepository() : base()
        {
        }

        public StepRepository(SurveyItDBContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Step> FindByHotsiteId(int HotsiteId)
        {
            return dataContext.Steps
                .Include("Hotsite")
                .Where(s => s.HotsiteId == HotsiteId);
        }

        public Step FindByHotsiteIdAndStepId(int HotsiteId, int StepId)
        {
            return dataContext.Steps
                              .Include("Hotsite")
                              .Where(s => s.Id == StepId)
                              .Where(s => s.HotsiteId == HotsiteId)
                              .FirstOrDefault<Step>();
        }
    }
}
