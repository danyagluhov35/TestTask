using Microsoft.EntityFrameworkCore;
using MouseEvent.Infrastructure;


namespace MouseEvent.Infrastructure.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() 
        {
            Database.EnsureCreated();
        }

        public DbSet<MouseData> MouseData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-82QJ6HP;Database=EntityBase;Trusted_Connection=True;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
