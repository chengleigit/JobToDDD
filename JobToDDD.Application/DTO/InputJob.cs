using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobToDDD.Application.DTO
{
    public class InputJob
    {
        public string JobName { get; set; }
        public string JobPay { get; set; }
        public string Welfare { get; set; }
        public string Education { get; set; }
        public string WorkExperience { get; set; }
        public DateTime? PublishTime { get; set; }
        public int? CityId { get; set; }
    }
}
