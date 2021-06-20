using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ModelEF.Model
{
    public partial class NgoThanhTuanContext : DbContext
    {
        public NgoThanhTuanContext()
            : base("name=NgoThanhTuanContext")
        {
        }

        public virtual DbSet<Category> HangMucs { get; set; }
        public virtual DbSet<Product> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.IDCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.IDCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.StatusProduct)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
