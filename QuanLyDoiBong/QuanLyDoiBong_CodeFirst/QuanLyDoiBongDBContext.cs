namespace QuanLyDoiBong_CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QuanLyDoiBongDBContext : DbContext
    {
        // Your context has been configured to use a 'QuanLyDoiBongDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QuanLyDoiBong_CodeFirst.QuanLyDoiBongDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QuanLyDoiBongDBContext' 
        // connection string in the application configuration file.
        public QuanLyDoiBongDBContext()
            : base("QuanLyDoiBongDBContext")
        {

        }

        public virtual DbSet<doibong> Doibongs { get; set; }
        public virtual DbSet<cauthu> Cauthus { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

}