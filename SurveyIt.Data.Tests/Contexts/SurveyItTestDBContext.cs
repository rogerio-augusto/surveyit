using SurveyIt.Core.DomainEntities;
using SurveyIt.Infra.Data.Contexts;
using SurveyIt.Infra.Data.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.SqlServer;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyIt.Data.Tests.Contexts
{
    public class SurveyItTestDBContext : SurveyItDBContext
    {
        public SurveyItTestDBContext()
            : base(ConfigurationManager.ConnectionStrings["TestConnection"].ConnectionString)
        {
            var dataDirectory = ConfigurationManager.AppSettings["DataDirectory"];
            var absoluteDataDirectory = Path.GetFullPath(dataDirectory);
            AppDomain.CurrentDomain.SetData("DataDirectory", absoluteDataDirectory);
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Suppress code first model migration check
            Database.SetInitializer<SurveyItTestDBContext>(new AlwaysCreateInitializer());

            base.OnModelCreating(modelBuilder);
        }

        public void Seed(SurveyItTestDBContext context)
        {
            var hotsiteStepsA = new List<Step>() {
                new Step() {Title = "Step one A", Visible = true},
                new Step() {Title = "Step two A", Visible = true},
                new Step() {Title = "Step three A", Visible = true}
            };

            var hotsiteList = new List<Hotsite>() {
             new Hotsite() { Id = 1, Name = "Hotsite Test 1", Steps = hotsiteStepsA },
             new Hotsite() { Id = 2, Name = "Hotsite Test 2" },
             new Hotsite() { Id = 3, Name = "Hotsite Test 3" }
            };

            context.Hotsites.AddRange(hotsiteList);
            context.SaveChanges();
        }
    }
    public class DropCreateIfChangeInitializer : DropCreateDatabaseIfModelChanges<SurveyItTestDBContext>
    {
        protected override void Seed(SurveyItTestDBContext context)
        {
            context.Seed(context);
            base.Seed(context);
        }
    }

    public class CreateInitializer : CreateDatabaseIfNotExists<SurveyItTestDBContext>
    {
        protected override void Seed(SurveyItTestDBContext context)
        {
            context.Seed(context);
            base.Seed(context);
        }
    }

    public class AlwaysCreateInitializer : DropCreateDatabaseAlways<SurveyItTestDBContext>
    {
        protected override void Seed(SurveyItTestDBContext context)
        {
            context.Seed(context);
            base.Seed(context);
        }
    }
}
