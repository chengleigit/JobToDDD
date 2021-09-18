using JobToDDD.Domain.JobInfio;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace JobToDD.EntityFramework.Seed
{
    public class JobSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Job> _jobRepositoty;

        public JobSeedContributor(IRepository<Job> jobRepositoty)
        {
            _jobRepositoty = jobRepositoty;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _jobRepositoty.GetCountAsync() > 0)
            {
                return;
            }

            Job job = new Job()
            {
                JobName = ".NET 软件开发",
                City = new City() { CityNme = "合肥" },
                CityId = 1,
                Company = new Company() { CompanyName = "软件科技有限公司" },
                CompanyId = 1,
                JobPay = "8000",
                WorkExperience = ""
            };

            await _jobRepositoty.InsertAsync(job);
        }
    }
}