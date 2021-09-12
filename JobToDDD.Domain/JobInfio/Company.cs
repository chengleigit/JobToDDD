using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace JobToDDD.Domain.JobInfio
{
    public class Company : Entity<Guid>
    {
        public string CompanyName { get; set; }
        public string CompanyNature { get; set; }
        public string CompanySize { get; set; }
        public string IndustryType { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyIntroduce { get; set; }

    }
}
