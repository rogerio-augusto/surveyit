using SurveyIt.Core.DomainEntities;
using System.Data.Entity.ModelConfiguration;

namespace SurveyIt.Infra.Data.EntityConfiguration
{
    public class StepSchema : EntityTypeConfiguration<Step>
    {
        public StepSchema()
        {
            Property(s => s.Title).IsRequired();
            Property(s => s.HotsiteId).IsRequired();
            HasRequired(s => s.Hotsite).WithMany(h => h.Steps);

            HasMany(s => s.Questions)
                .WithRequired(q => q.Step)
                .WillCascadeOnDelete(true);
        }
    }
}
