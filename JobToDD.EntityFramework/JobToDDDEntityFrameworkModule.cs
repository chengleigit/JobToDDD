using JobToDDD.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace JobToDD.EntityFramework
{
    [DependsOn(
      typeof(AbpEntityFrameworkCoreModule),
      typeof(JobToDDDDomainMoudle)
        )]
    public class JobToDDDEntityFrameworkModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<JobToDDDDbContext>(opt =>
            {
                opt.AddDefaultRepositories(true);
            });

            Configure<AbpDbContextOptions>(opt =>
            {
                opt.UseSqlServer();
            });
            
        }
    } 
}
