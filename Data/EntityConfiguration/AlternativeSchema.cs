using SurveyIt.Core.DomainEntities;
using System.Data.Entity.ModelConfiguration;

namespace SurveyIt.Data.EntityConfiguration
{
    public class AlternativeSchema : EntityTypeConfiguration<Alternative>
    {
        public AlternativeSchema()
        {
            Property(a => a.QuestionId).IsRequired();
            Property(a => a.Description).IsRequired();
            Property(a => a.Description).HasMaxLength(250);

            HasRequired(a => a.Question).WithMany(q => q.Alternatives);
        }
    }
}
