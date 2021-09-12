using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace JobToDDD.Domain.JobInfio
{
    public class Job : Entity<Guid>
    {
        public string JobName { get; set; }
        public string JobPay { get; set; }
        public string Welfare { get; set; }
        public string Education { get; set; }
        public string WorkExperience { get; set; }
        public DateTime? PublishTime { get; set; }
        public int? CityId { get; set; }
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual City City { get; set; }

    }
}
