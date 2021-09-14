using JobToDDD.Domain.JobInfio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace JobToDD.EntityFramework
{
    [ConnectionStringName("Default")]
    public class JobToDDDDbContext : AbpDbContext<JobToDDDDbContext>
    {
        public JobToDDDDbContext(DbContextOptions<JobToDDDDbContext> options) : base(options)
        {
        }



        public DbSet<Job> Jobs { get; set; }
    }
}
