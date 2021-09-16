using JobToDDD.Domain.JobInfio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace JobToDDD.Application.JobApp
{
    public interface IJobService:IApplicationService
    {
        public Task<List<Job>> GetAllJobs();
    }
}
