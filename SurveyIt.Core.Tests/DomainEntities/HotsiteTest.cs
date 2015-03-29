using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurveyIt.Core.DomainEntities;
using System;

namespace SurveyIt.Tests
{
    [TestClass]
    public class HotsiteTest
    {
        [TestMethod]
        public void ItShouldNotBeOpenUnlessPublished()
        {
            var tomorrow = DateTime.Now.AddDays(1);
            var hotsite = new Hotsite { Published = false, Deadline = tomorrow };

            Assert.IsFalse(hotsite.IsOpen());
        }

        [TestMethod]
        public void ItShouldNotBeOpenAfterDeadline()
        {
            var currentDateTime = DateTime.Now;
            var missedDeadline = currentDateTime.AddDays(-1);
            var hotsite = new Hotsite { Published = true, Deadline = missedDeadline };

            Assert.IsFalse(hotsite.IsOpen());
        }

        [TestMethod]
        public void ItShouldBeOpenIfPublishedAndBeforeReachedDeadline()
        {
            var tomorrow = DateTime.Now.AddDays(1);
            var hotsite = new Hotsite { Published = true, Deadline = tomorrow };

            Assert.IsTrue(hotsite.IsOpen());
        }
    }
}
