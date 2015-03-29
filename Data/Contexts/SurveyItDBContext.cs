using SurveyIt.Core.DomainEntities;
using SurveyIt.Infra.Data.EntityConfiguration;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SurveyIt.Infra.Data.Contexts
{
    public class SurveyItDBContext : DbContext
    {
        public SurveyItDBContext()
            : base("SurveItConnection")
        {}

        public SurveyItDBContext(string connectionString)
            : base(connectionString)
        {}

        public DbSet<Hotsite> Hotsites { get; set; }
        public DbSet<Step> Steps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<DateTime>().Configure(p => p.HasColumnType("datetime2"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new HotsiteSchema());
            modelBuilder.Configurations.Add(new StepSchema());

            base.OnModelCreating(modelBuilder);  
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
