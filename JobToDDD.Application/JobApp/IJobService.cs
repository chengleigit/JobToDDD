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
        Task<List<Job>> GetAllJobsAsync();
        Task<Job> InsertJobAsync(Job input);
        Task<string> DeleteJobAsync(Guid id);
        Task<Job> UpdateJobAsync(Guid id,Job input);
    }
}
