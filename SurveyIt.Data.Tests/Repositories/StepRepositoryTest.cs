using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurveyIt.Core.DomainEntities;
using SurveyIt.Data.Repositories;
using SurveyIt.Data.Tests.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyIt.Data.Tests.Repositories
{
    [TestClass]
    public class StepRepositoryTest
    {
        private SurveyItTestDBContext dbContext;
        private StepRepository testStepRepository;

        [TestInitialize]
        public void TestSetup()
        {
            Database.SetInitializer<SurveyItTestDBContext>(new AlwaysCreateInitializer());
            dbContext = new SurveyItTestDBContext();
            testStepRepository = new StepRepository(dbContext);
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void FindByHotsiteId()
        {
            var steps = testStepRepository.FindByHotsiteId(1).ToList<Step>();

            Assert.AreEqual(3, steps.Count);
            Assert.IsNotNull(steps[0].Hotsite.Name);
        }

        [TestMethod]
        public void FindByHotsiteIdAndStepId()
        {
            var step2A = testStepRepository.FindByHotsiteIdAndStepId(1, 2);
            var nullStep = testStepRepository.FindByHotsiteIdAndStepId(2, 1);

            Assert.AreEqual("Step two A", step2A.Title);
            Assert.IsNotNull(step2A.Hotsite.Name);
            Assert.IsNull(nullStep);
        }
    }
}
