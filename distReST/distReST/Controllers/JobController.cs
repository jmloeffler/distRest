using distReST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace distReST.Controllers
{
    public class JobController : ApiController
    {
        private IJobRepository _repository;

        public JobController(IJobRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        public IEnumerable<Job> Get()
        {
            return _repository.GetJobs();
        }

        // GET api/values/5
        public Job Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/values
        public void Post([FromBody]Job value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Job value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}