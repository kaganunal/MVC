using Microsoft.EntityFrameworkCore;

namespace DTO_API_VIEW.Models
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Classes> Classes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Initial Catalog=CSDb; Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOne(x => x.StudentClasses).WithMany(x => x.Students).HasForeignKey(x => x.ClassId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
