using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiTap14.Models
{
    public partial class WineStore2 : DbContext
    {
        public WineStore2()
            : base("name=WineStore2")
        {
        }

        public virtual DbSet<nguoidung> nguoidungs { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.CatalogyID)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .IsUnicode(false);
        }
    }
}
