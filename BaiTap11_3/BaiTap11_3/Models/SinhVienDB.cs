using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiTap11_3.Models
{
    public partial class SinhVienDB : DbContext
    {
        public SinhVienDB()
            : base("name=SinhVienDB")
        {
        }

        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaMon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
