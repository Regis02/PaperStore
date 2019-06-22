using Microsoft.EntityFrameworkCore;
using PaperStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaperStore
{
    public class PaperContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceSupplies> InvoiceSupplies { get; set; }
        public DbSet<RelationCode> RelationCode { get; set; }
        public DbSet<Supplies> Supplies { get; set; }
        public PaperContext(DbContextOptions<PaperContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceSupplies>().HasKey(t => new { t.InvoiceId, t.SuppliesId });
        }

    }
}
