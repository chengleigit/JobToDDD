using JobToDD.EntityFramework.Seed;
using JobToDDD.Domain.JobInfio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace JobToDD.EntityFramework
{
    [ConnectionStringName("Default")]
    public class JobToDDDDbContext : AbpDbContext<JobToDDDDbContext>
    {
        public DbSet<Job> Jobs { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Requirement> Requirement { get; set; }

        public JobToDDDDbContext(DbContextOptions<JobToDDDDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Always call the base method
            base.OnModelCreating(builder);

            builder.Entity<Job>(b =>
            {
                b.ToTable("Jobs");

                b.ConfigureByConvention();

                b.Property(x => x.JobName).IsRequired().HasMaxLength(128);
            });

        }
        
    }
}
