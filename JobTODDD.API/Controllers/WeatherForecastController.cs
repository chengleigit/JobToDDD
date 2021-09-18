using JobToDDD.Application.JobApp;
using JobToDDD.Domain.JobInfio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobToDDD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IJobService _JobService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IJobService JobService)
        {
            _logger = logger;
            _JobService = JobService;
        }

        /// <summary>
        /// 测试接口
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Job>> TestAPI()
        {

            return await  _JobService.GetAllJobsAsync();

        }



        /// <summary>
        /// 测试获取
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        /// <summary>
        /// 新增
        /// </summary>
        [HttpPost]
        public void Post()
        {

        }

        /// <summary>
        /// 修改
        /// </summary>
        [HttpPut]
        public void Put()
        {

        }

        /// <summary>
        /// 删除
        /// </summary>
        [HttpDelete]
        public void Delete()
        {

        }
    }
}
