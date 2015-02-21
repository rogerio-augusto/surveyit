using SurveyIt.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SurveyIt.Infra.Data.EntityConfiguration
{
    public class HotsiteSchema : EntityTypeConfiguration<Hotsite>
    {
        public HotsiteSchema()
        {
            Property(h => h.Name).IsRequired();
            Property(h => h.Deadline).IsRequired();
        }
    }
}
