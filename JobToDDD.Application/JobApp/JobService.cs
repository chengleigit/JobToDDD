using JobToDDD.Domain.JobInfio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace JobToDDD.Application.JobApp
{
    public class JobService : ApplicationService, IJobService
    {
        private readonly IRepository<Job> _jobRepo;
        public JobService(IRepository<Job> jobRepo)
        {
            _jobRepo =  jobRepo;
        }
        public void GetJobs()
        {
            var jobs = _jobRepo.GetListAsync().Result;
        }
    }
}
