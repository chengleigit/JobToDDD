using System;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace JobToDDD.Domain
{
    [DependsOn(
      typeof(AbpDddDomainModule)
        )]
    public class JobToDDDDomainMoudle:AbpModule
    {
    }
}
