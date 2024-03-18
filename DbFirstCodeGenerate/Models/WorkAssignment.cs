using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstCodeGenerate.Models
{
    public class WorkAssignment
    {
        [Key] 
        public int WorkAssigmentID { get; set; }
        public int? PersonelID {  get; set; }

        public Personel Personel {  get; set; }

        public int? ServiceID { get; set; }

        public ServiceRecord ServiceRecord { get; set; }





    }
}
