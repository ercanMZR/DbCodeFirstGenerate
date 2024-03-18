using System.ComponentModel.DataAnnotations;

namespace DbFirstCodeGenerate.Models
{
    public class ServiceStatus
    {
        [Key]
        public string StatusID { get; set; }
        [MaxLength(25)]
        public string StatusName { get; set; }
        [MaxLength (50)]
        public string Description { get; set; }

    }
}