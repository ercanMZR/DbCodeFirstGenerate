using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstCodeGenerate.Models
{
    public  class ServiceRecord
    {
        [Key]
        public int ServiceID { get; set; }

        public int? CostumerID { get; set; }
        public Customer Customer { get; set; }

        [MaxLength(25)]
        public string DeviceType { get; set; }
        [MaxLength(25)]
        public string Brand {  get; set; }
        [MaxLength (25)]
        public string Serialnumber { get; set; }
        [MaxLength(25)]

        public string DefectDescription { get; set; }


        public DateTime AcceptanceDate { get; set; }

        public DateTime EstimatedCompletionDate { get; set; }


        public int? StatusID { get; set; }

        public ServiceStatus ServiceStatus { get; set; }



       


    }
}
