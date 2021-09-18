using JobToDDD.Domain.JobInfio;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _jobRepo = jobRepo;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _jobRepo.GetListAsync();
        }

        public async Task<Job> InsertJobAsync(Job input)
        {
            return await _jobRepo.InsertAsync(input);
        }

        public async Task<Job> UpdateJobAsync(Guid id, Job input)
        {
            var jobData = _jobRepo.Where(i => i.Id == id).FirstOrDefault();

            if (jobData == null)
            {
                throw new Exception("未查到要更新的信息！！");
            }

            jobData.JobName = input.JobName;
            jobData.JobPay = input.JobPay;
            jobData.CityId = input.CityId;
            jobData.CompanyId = input.CompanyId;
            jobData.Education = input.Education;
            jobData.WorkExperience = input.WorkExperience;
            jobData.PublishTime = input.PublishTime;

            return await _jobRepo.UpdateAsync(jobData);
        }

        public async Task<string> DeleteJobAsync(Guid id)
        {
            var jobData = _jobRepo.FirstOrDefault(i => i.Id == id);

            if (jobData == null)
            {
                throw new Exception("未查到信息！！");
            }

            await _jobRepo.DeleteAsync(jobData);

            return "删除成功！！";
        }
    }
}