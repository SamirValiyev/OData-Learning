using Microsoft.EntityFrameworkCore;
using OData_Learning.Entities;

namespace OData_Learning.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
        }

    }
}
