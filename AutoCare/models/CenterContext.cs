using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoCare.models
{
    public partial class CenterContext : DbContext
    {
        public CenterContext()
            : base("name=CenterContext")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientBill> ClientBills { get; set; }
        public virtual DbSet<ClientBillItem> ClientBillItems { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierBill> SupplierBills { get; set; }
        public virtual DbSet<SupplierBillItem> SupplierBillItems { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<WorkerAdvancePayment> WorkerAdvancePayments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Cars)
                .WithOptional(e => e.Client)
                .WillCascadeOnDelete();
        }
    }
}
