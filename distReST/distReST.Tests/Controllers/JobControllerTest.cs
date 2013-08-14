using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using distReST;
using distReST.Controllers;
using distReST.Models;
using Moq;

namespace distReST.Tests.Controllers
{
    [TestClass]
    public class JobControllerTest
    {
        private Mock<IJobRepository> _repository;
        private JobController _testObject;

        [TestInitialize]
        public void Setup()
        {
            _repository = new Mock<IJobRepository>();
            _testObject = new JobController(_repository.Object);
        }

        [TestCleanup]
        public void Teardown()
        {
            _repository.VerifyAll();
        }

        [TestMethod]
        public void Get()
        {
            var job = new Mock<IJob>();
            _repository.Setup(r => r.GetJobs()).Returns(new []{job.Object});

            var result = _testObject.Get();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreSame(job.Object, result.ElementAt(0));
        }

        [TestMethod]
        public void Put()
        {
            var job = new Mock<IJob>();
            _repository.Setup(r => r.AddJob(job.Object));

            _testObject.Put(1, job.Object);
        }
    }
}
