using JobToDDD.Application.JobApp;
using JobToDDD.Domain.JobInfio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobToDDD.Controllers
{

    /// <summary>
    /// 工作控制器
    /// </summary>

    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _JobService;
        public JobController(IJobService jobService)
        {
            _JobService = jobService;
        }


        /// <summary>
        /// 获取所有信息
        /// </summary>
        [HttpGet]
        public async Task<List<Job>> GetJobAsync()
        {
            return await _JobService.GetAllJobsAsync();
        }
        /// <summary>
        /// 新增
        /// </summary>
        [HttpPost]
        public async Task<Job> PostJobAsync(Job input)
        {
            return await _JobService.InsertJobAsync(input);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<Job> UpdateJob(Guid id,Job input) 
        {
            return await _JobService.UpdateJobAsync(id,input);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<string> DeleteJob(Guid id)
        {
            return await _JobService.DeleteJobAsync(id);
        }




    }
}
