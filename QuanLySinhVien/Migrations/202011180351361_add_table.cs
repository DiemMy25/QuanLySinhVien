namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiemThis",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 20),
                        MaMH = c.String(nullable: false, maxLength: 20),
                        KetQua = c.String(nullable: false, maxLength: 30),
                        LanThi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSV)
                .ForeignKey("dbo.SinhViens", t => t.MaSV)
                .Index(t => t.MaSV);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 20),
                        TenSV = c.String(nullable: false, maxLength: 30),
                        GioiTinh = c.String(),
                        NgaySinh = c.String(),
                        MaLop = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.MaSV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiemThis", "MaSV", "dbo.SinhViens");
            DropIndex("dbo.DiemThis", new[] { "MaSV" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.DiemThis");
        }
    }
}
