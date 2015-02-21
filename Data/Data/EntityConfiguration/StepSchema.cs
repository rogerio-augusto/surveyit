using SurveyIt.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SurveyIt.Infra.Data.EntityConfiguration
{
    public class StepSchema : EntityTypeConfiguration<Step>
    {
        public StepSchema()
        {
            Property(s => s.Title).IsRequired();
            Property(s => s.HotsiteId).IsRequired();
        }
    }
}
