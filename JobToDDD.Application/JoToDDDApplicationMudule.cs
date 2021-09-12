using JobToDD.EntityFramework;
using System;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace JobToDDD.Application
{
    [DependsOn(
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(JobToDDDEntityFrameworkModule)
         )]
    public class JoToDDDApplicationMudule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(opt=> {
                opt.AddProfile<JobToDDDProfile>();
            });
        }
    }
}
