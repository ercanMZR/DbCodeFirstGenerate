using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstCodeGenerate.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }

        public int? ServiceID { get; set; }

        public ServiceRecord ServiceRecord { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime PaymentDate { get; set;}

        public decimal TotalPrice { get; set;}


    }
}
