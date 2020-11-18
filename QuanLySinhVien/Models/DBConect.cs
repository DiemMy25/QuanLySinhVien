namespace QuanLySinhVien.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBConect : DbContext
    {
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<DiemThi> DiemThis { get; set; }
        public DBConect()
            : base("name=DBConect")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
