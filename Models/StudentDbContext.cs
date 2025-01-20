using Microsoft.EntityFrameworkCore;

namespace FirstcoreApp.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0H6GGHA;Initial Catalog=Core_db;User ID=sa;Password=123;Encrypt=False");
        }





    }
}
