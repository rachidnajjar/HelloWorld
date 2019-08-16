using Microsoft.EntityFrameworkCore;

namespace HelloWorld
{
    public class HelloWorldContext : DbContext
    {
        private const string ConnectionString = "Data Source=HelloWorld.db";

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }

    }
}