namespace QuanLySinhVien.Migrations
{
    using QuanLySinhVien.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanLySinhVien.Models.DBConect>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuanLySinhVien.Models.DBConect context)
        {
            context.SinhViens.AddOrUpdate(s => s.TenSV,
                new SinhVien
                {
                    TenSV = " Nguyễn Văn A",
                    GioiTinh = "nam",
                    NgaySinh = "01/01/1998",
                    MaLop = "A",

                },
                new SinhVien
                {
                    TenSV = " Trần Thị B",
                    GioiTinh = "nu",
                    NgaySinh = "09/01/1998",
                    MaLop = "A",

                },
                new SinhVien
                {
                    TenSV = " Nguyễn Trung C",
                    GioiTinh = "nam",
                    NgaySinh = "01/07/1998",
                    MaLop = "B",

                }
                );
        }
    }
}
