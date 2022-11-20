using Microsoft.EntityFrameworkCore;

namespace Module25.Practice
{
    public class AppContext : DbContext
    {
        #region Unit3+4
        //// Объекты таблицы Users
        //public DbSet<User> Users { get; set; }
        //// Объекты таблицы Companies
        //public DbSet<Company> Companies { get; set; } //Unit4 + Один ко многим
        //// Объекты таблицы UserCredentials
        //public DbSet<UserCredential> UserCredentials { get; set; } //Unit4 Один к одному
        //// Объекты таблицы Topics
        //public DbSet<Topic> Topics { get; set; } //Unit4 Многие ко многим

        //public AppContext()
        //{
        //    Database.EnsureDeleted(); //Unit4
        //    Database.EnsureCreated();
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=EF;Trusted_Connection=True;TrustServerCertificate=True;");
        //}
        #endregion
        #region Unit5
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }
        // Объекты таблицы Companies
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=EF;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        #endregion
    }
}
