using SurveyIt.Core.DomainEntities;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace SurveyIt.Infra.Data.EntityConfiguration
{
    public class HotsiteSchema : EntityTypeConfiguration<Hotsite>
    {
        public HotsiteSchema()
        {
            Property(h => h.Name).IsRequired();
            Property(h => h.Deadline).IsRequired();
            
            HasMany(h => h.Steps)
                .WithRequired(s => s.Hotsite)
                .WillCascadeOnDelete(true);
        }
    }
}
