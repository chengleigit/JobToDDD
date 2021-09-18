using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace JobToDD.EntityFramework.Seed
{
    public class MyJobSeedService : ITransientDependency
    {
        private readonly IDataSeeder _dataSeeder;
        public MyJobSeedService(IDataSeeder dataSeeder)
        {
            _dataSeeder = dataSeeder;
        }
        public async Task FooAsync()
        {
            await _dataSeeder.SeedAsync();
        }

    }
}
