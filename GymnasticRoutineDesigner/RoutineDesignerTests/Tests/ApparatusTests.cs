using BusinessLogic.Repositories;
using DataAcces.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoutineDesignerTests.MockContexts;
using BusinessLogic.Models;
using System;

namespace RoutineDesignerTests.Tests
{
    [TestClass]
    public class ApparatusTests
    {
        private readonly IApparatusContext IApp;
        private readonly ApparatusRepository Repo;
        public ApparatusTests()
        {
            IApp = new MockApparatusContext();
            Repo = new ApparatusRepository(IApp);
        }

        [TestMethod]
        public void ApparatusById_ValidId()
        {
            int Id = 1;

            Apparatus app = Repo.GetById(Id);

            Assert.AreEqual(Id, app.Id);
        }

        [TestMethod]
        public void ApparatusById_InvalidId()
        {
            int Id = 6;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Repo.GetById(Id));
        }

        [TestMethod]
        public void SkillGroupFromApparatus_ValidId()
        {
            int Id = 1;

            Apparatus app = Repo.GetSkillGroups(Id);

            Assert.IsTrue(app.SkillGroups.Count > 0);
        }
        [TestMethod]
        public void SkillGroupFromApparatus_InvalidId()
        {
            int Id = 6;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Repo.GetSkillGroups(Id));
        }
    }
}
