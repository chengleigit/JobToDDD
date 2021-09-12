using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace JobToDDD.Domain.JobInfio
{
    public class City : Entity<Guid>
    {
        public string CityNme { get; set; }

        public int? AdministrativeLevel { get; set; }

    }
}
