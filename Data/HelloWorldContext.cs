using Microsoft.EntityFrameworkCore;
using HelloWorld.Models;

namespace HelloWorld.Data
{
    public class HelloWorldContext : DbContext
    {
        private const string ConnectionString = "Data Source=HelloWorld.db";

        public DbSet<Employe> Employes { get; set; }
        public DbSet<TypeTelephone> TypeTelephones { get; set; }
        public DbSet<Telephone> Telephones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlite(ConnectionString);
        }

    }
}