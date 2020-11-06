using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>()
                .Property(s => s.Description).IsRequired().HasMaxLength(100);
            base.OnModelCreating(modelBuilder);
        }
    }
}