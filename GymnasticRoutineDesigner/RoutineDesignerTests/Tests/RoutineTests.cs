using BusinessLogic.Repositories;
using DataAcces.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoutineDesignerTests.MockContexts;
using BusinessLogic.Models;
using System;

namespace RoutineDesignerTests.Tests
{
    [TestClass]
    public class RoutineTests
    {
        private readonly IRoutineContext IRoutine;
        private readonly RoutineRepository Repo;
        public RoutineTests()
        {
            IRoutine = new MockRoutineContext();
            Repo = new RoutineRepository(IRoutine);
        }

        [TestMethod]
        public void RoutineById_ValidId()
        {
            int Id = 1;

            Routine routine = Repo.GetById(Id);

            Assert.AreEqual(Id, routine.Id);
            Assert.IsTrue(routine.Elements.Count > 0);
        }

        [TestMethod]
        public void RoutineById_InvalidId()
        {
            int Id = 103766;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Repo.GetById(Id));
        }
    }
}
