using Microsoft.EntityFrameworkCore;
using OData_Learning.Entities;

namespace OData_Learning.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions):base(dbContextOptions) 
        {
            
        }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Grade>().HasMany(x=>x.Students)
                                        .WithOne(x=>x.Grade)
                                        .HasForeignKey(x=>x.GradeId);

            modelBuilder.Entity<Grade>().HasData(
                     new Grade
                     {
                         Id=1,
                         Name="First"
                     },
                     new Grade
                     {
                         Id=2,
                         Name = "Second"
                     },
                     new Grade
                     {
                         Id=3,
                         Name = "Third"
                     },
                     new Grade
                     {
                         Id=4,
                         Name = "Fourth"
                     },
                     new Grade
                     {
                         Id=5,
                         Name = "Fifth"
                     }
            );


            modelBuilder.Entity<Student>().HasData(
                     new Student
                     {
                         Id = 1,
                         FirstName = "Rauf",
                         LastName = "Salahov",
                         EmailAddress = "rauf.salahov@example.com",
                         GradeId = 1,
                         CreatedDate = new DateTime(2026, 1, 5)
                     },
                     new Student
                     {
                         Id = 2,
                         FirstName = "Zahra",
                         LastName = "Nabiyeva",
                         EmailAddress = "zahra.nabiyeva@example.com",
                         GradeId = 2,
                         CreatedDate = new DateTime(2026, 1, 8)
                     },
                     new Student
                     {
                         Id = 3,
                         FirstName = "Emil",
                         LastName = "Musayev",
                         EmailAddress = "emil.musayev@example.com",
                         GradeId = 3,
                         CreatedDate = new DateTime(2026, 1, 12)
                     },
                     new Student
                     {
                         Id = 4,
                         FirstName = "Narmin",
                         LastName = "Shiriyeva",
                         EmailAddress = "narmin.shiriyeva@example.com",
                         GradeId = 4,
                         CreatedDate = new DateTime(2026, 1, 15)
                     },
                     new Student
                     {
                         Id = 5,
                         FirstName = "Javid",
                         LastName = "Orujov",
                         EmailAddress = "javid.orujov@example.com",
                         GradeId = 5,
                         CreatedDate = new DateTime(2026, 1, 18)
                     },
                     new Student
                     {
                         Id = 6,
                         FirstName = "Konul",
                         LastName = "Isgandarova",
                         EmailAddress = "konul.isgandarova@example.com",
                         GradeId = 1,
                         CreatedDate = new DateTime(2026, 1, 21)
                     },
                     new Student
                     {
                         Id = 7,
                         FirstName = "Fuad",
                         LastName = "Bayramli",
                         EmailAddress = "fuad.bayramli@example.com",
                         GradeId = 2,
                         CreatedDate = new DateTime(2026, 1, 24)
                     },
                     new Student
                     {
                         Id = 8,
                         FirstName = "Sabina",
                         LastName = "Huseynli",
                         EmailAddress = "sabina.huseynli@example.com",
                         GradeId = 3,
                         CreatedDate = new DateTime(2026, 1, 27)
                     },
                     new Student
                     {
                         Id = 9,
                         FirstName = "Elnur",
                         LastName = "Veliyev",
                         EmailAddress = "elnur.veliyev@example.com",
                         GradeId = 4,
                         CreatedDate = new DateTime(2026, 2, 1)
                     },
                     new Student
                     {
                         Id = 10,
                         FirstName = "Amina",
                         LastName = "Safarli",
                         EmailAddress = "amina.safarli@example.com",
                         GradeId = 5,
                         CreatedDate = new DateTime(2026, 2, 4)
                     },
                     new Student
                     {
                         Id = 11,
                         FirstName = "Tofig",
                         LastName = "Guliyev",
                         EmailAddress = "tofig.guliyev@example.com",
                         GradeId = 1,
                         CreatedDate = new DateTime(2026, 2, 7)
                     },
                     new Student
                     {
                         Id = 12,
                         FirstName = "Lala",
                         LastName = "Karimzade",
                         EmailAddress = "lala.karimzade@example.com",
                         GradeId = 5,
                         CreatedDate = new DateTime(2026, 2, 10)
                     }
                 );

            base.OnModelCreating(modelBuilder);
        }

    }
}
