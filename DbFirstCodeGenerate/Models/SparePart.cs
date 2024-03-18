using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstCodeGenerate.Models
{
    public class SparePart
    {
        [Key]
        public int  SpareID { get; set; }
        [MaxLength(50)]
        public string SpareName { get; set; }
        [MaxLength(50)]
        public string SpareBrand { get; set; }
        [MaxLength (50)]

        public string SpareModel { get; set; }

        public short? AmountOfStock { get; set; }

        public decimal? Price { get; set; }

    }
}
