using distReST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace distReST.Controllers
{
    public interface IJobRepository
    {
        IEnumerable<IJob> GetJobs();

        void AddJob(IJob job);
    }

    public class JobRepository : IJobRepository
    {
        private List<IJob> _jobs = new List<IJob>();

        public IEnumerable<IJob> GetJobs()
        {
            return _jobs;
        }

        public void AddJob(IJob job)
        {
            _jobs.Add(job);
        }
    }
}
