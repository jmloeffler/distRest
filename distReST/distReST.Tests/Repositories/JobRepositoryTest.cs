using distReST.Controllers;
using distReST.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distReST.Tests.Repositories
{
    [TestClass]
    public class JobRepositoryTest
    {
        private IJobRepository _testObject;

        [TestInitialize]
        public void Setup()
        {
            _testObject = new JobRepository();
        }

        [TestMethod]
        public void AddJob_Stores_the_Given_Job()
        {
            var job = new Moq.Mock<IJob>();
            _testObject.AddJob(job.Object);

            Assert.IsTrue(_testObject.GetJobs().Contains(job.Object));
        }

    }
}
