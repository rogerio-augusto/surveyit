using SurveyIt.Core.DomainEntities;
using System.Data.Entity.ModelConfiguration;

namespace SurveyIt.Data.EntityConfiguration
{
    public class QuestionSchema : EntityTypeConfiguration<Question>
    {
        public QuestionSchema()
        {
            Property(q => q.Description).IsRequired();
            Property(q => q.Description).HasMaxLength(250);
            Property(q => q.SetpId).IsRequired();

            HasRequired(s => s.Step).WithMany(s => s.Questions);

            HasMany(q => q.Alternatives)
                .WithRequired(a => a.Question)
                .WillCascadeOnDelete(true);
        }
    }
}
