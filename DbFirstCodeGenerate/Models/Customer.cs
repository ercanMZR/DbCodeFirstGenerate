using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstCodeGenerate.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(25)]
        public string? LastName { get; set; }
        [MaxLength(25)]
        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Adress { get; set; }


    }
}
