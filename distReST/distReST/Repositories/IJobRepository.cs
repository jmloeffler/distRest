using distReST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace distReST.Controllers
{
    public interface IJobRepository
    {
        IEnumerable<Job> GetJobs();
    }

    public class JobRepository : IJobRepository
    {
        public IEnumerable<Job> GetJobs()
        {
            throw new NotImplementedException();
        }
    }
}
