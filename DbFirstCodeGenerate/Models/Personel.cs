using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstCodeGenerate.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }

        [MaxLength (50)]
        public string? PersonelName { get; set; }
        [MaxLength (50)]

        public string? PersonelLastName { get; set; }
        [MaxLength(25)]
        public string? Position { get; set; }
        [MaxLength(11)]
        public string? PhoneNumber { get; set; }

        public string EMail { get; set; }

        public DateTime InitialDate { get; set; }





    }
}
