using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurveyIt.Core.DomainEntities;
using SurveyIt.Data.Tests.Contexts;
using SurveyIt.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Transactions;

namespace SurveyIt.Data.Tests.Repositories
{
    [TestClass]
    public class RepositoryBaseTest
    {
        private SurveyItTestDBContext dbContext;
        private RepositoryBase<Hotsite> testRepositoryBase;

        [TestInitialize]
        public void TestSetup()
        {
            Database.SetInitializer<SurveyItTestDBContext>(new AlwaysCreateInitializer());
            dbContext = new SurveyItTestDBContext();
            testRepositoryBase = new RepositoryBase<Hotsite>(dbContext);
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void DatabaseSeedShouldCreateThreeHotsites()
        {
            var hotsiteList = (List<Hotsite>)testRepositoryBase.FindAll();

            Assert.AreEqual(3, hotsiteList.Count);
        }

        [TestMethod]
        public void ItShouldCreateAnyValidModel()
        {
            var hotsite = new Hotsite { Name = "Hotsite Test 4", Deadline = DateTime.Now.AddMonths(1) };
            testRepositoryBase.Create(hotsite);

            Assert.IsNotNull(hotsite.Id);
        }

        [TestMethod]
        public void ItShouldFindById()
        {
            var hotsite = testRepositoryBase.Find(2);

            Assert.AreEqual("Hotsite Test 2", hotsite.Name);
        }

        [TestMethod]
        public void ItShouldUpdateSomeValue()
        {
            var hotsite = testRepositoryBase.Find(2);
            hotsite.Name = "Updated Hotsite Test 2";
            testRepositoryBase.Update(hotsite);
            
            hotsite = testRepositoryBase.Find(2);
            Assert.AreEqual("Updated Hotsite Test 2", hotsite.Name);
        }

        [TestMethod]
        public void ItShouldDeleteARecord()
        {
            var hotsiteList = (List<Hotsite>)testRepositoryBase.FindAll();
            var hotsiteCount = hotsiteList.Count;

            testRepositoryBase.Delete(hotsiteList[1]);

            hotsiteList = (List<Hotsite>)testRepositoryBase.FindAll();
            Assert.AreEqual((hotsiteCount - 1), hotsiteList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Data.Entity.Validation.DbEntityValidationException))]
        public void ItShouldNotCreateAnInvalidModel()
        {
            var hotsite = new Hotsite();
            testRepositoryBase.Create(hotsite);
        }
    }
}