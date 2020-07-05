namespace QuanLyDoiBong_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanLyDoiBong_CodeFirst.QuanLyDoiBongDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuanLyDoiBong_CodeFirst.QuanLyDoiBongDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Doibongs.Add(new doibong()
            {
                MaDoiBong = "HAGL",
                TenDoiBong = "Hoàng Anh Gia Lai"
            });

            context.Doibongs.Add(new doibong()
            {
                MaDoiBong = "HN",
                TenDoiBong = "Hà Nội"
            });

            context.Cauthus.Add(new cauthu()
            {
                MaCauThu = "U23_HAGL_001",
                TenCauThu = "Nguyễn Văn An",
                Sodt = "0903998877",
                Email = "nguanan@yahoo.com",
                IdDoiBong = "HAGL"
            });

            context.Cauthus.Add(new cauthu()
            {
                MaCauThu = "U23_HAGL_100",
                TenCauThu = "Hoàng Văn Ban",
                Sodt = "0903445566",
                Email = "nguehw@yahoo.com",
                IdDoiBong = "HAGL"
            });

        }
    }
}
