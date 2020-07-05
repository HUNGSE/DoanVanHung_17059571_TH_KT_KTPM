namespace QuanLyDoiBong_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaoCSDLV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cauthus",
                c => new
                    {
                        MaCauThu = c.String(nullable: false, maxLength: 128),
                        TenCauThu = c.String(),
                        Sodt = c.String(),
                        Email = c.String(),
                        IdDoiBong = c.String(),
                        DoiBong_MaDoiBong = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaCauThu)
                .ForeignKey("dbo.doibongs", t => t.DoiBong_MaDoiBong)
                .Index(t => t.DoiBong_MaDoiBong);
            
            CreateTable(
                "dbo.doibongs",
                c => new
                    {
                        MaDoiBong = c.String(nullable: false, maxLength: 128),
                        TenDoiBong = c.String(),
                    })
                .PrimaryKey(t => t.MaDoiBong);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.cauthus", "DoiBong_MaDoiBong", "dbo.doibongs");
            DropIndex("dbo.cauthus", new[] { "DoiBong_MaDoiBong" });
            DropTable("dbo.doibongs");
            DropTable("dbo.cauthus");
        }
    }
}
