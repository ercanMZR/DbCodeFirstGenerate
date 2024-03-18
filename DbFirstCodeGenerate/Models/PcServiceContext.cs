using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstCodeGenerate.Models
{
    public class PcServiceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2KEA18U\SQLEXPRESS; Database=ComputerRepairService;trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<ServiceRecord> ServiceRecords { get; set; }


        public DbSet<SparePart> SpareParts { get; set; }

        public DbSet<Personel> Personel { get; set; }

        public DbSet<ServiceStatus> ServiceStatus { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<WorkAssignment> WorkAssignments { get; set; }



    }
}
