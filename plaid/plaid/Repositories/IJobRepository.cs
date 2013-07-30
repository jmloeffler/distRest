using plaid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace plaid.Controllers
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
