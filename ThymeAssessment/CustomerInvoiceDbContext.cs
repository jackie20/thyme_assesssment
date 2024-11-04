using Microsoft.EntityFrameworkCore;
using ThymeAssessment.Models;

namespace ThymeAssessment
{
    public class CustomerInvoiceDbContext : DbContext
    {
        public CustomerInvoiceDbContext(DbContextOptions<CustomerInvoiceDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceHeader> InvoiceHeaders { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
            .ToTable("Customer");

            modelBuilder.Entity<InvoiceHeader>()
           .ToTable("InvoiceHeader");


            modelBuilder.Entity<InvoiceDetail>()
           .ToTable("InvoiceDetail");


            modelBuilder.Entity<Invoice>()
           .ToTable("Invoices");
        }
    }
}
