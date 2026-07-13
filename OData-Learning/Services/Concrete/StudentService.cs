using OData_Learning.Entities;
using OData_Learning.Services.Abstract;

namespace OData_Learning.Services.Concrete
{
    public class StudentService : IStudentService
    {
        public IEnumerable<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Mammadov",
                    EmailAddress = "ali.mammadov@example.com",
                    GradeId = 1,
                    CreatedDate = DateTime.Now
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Nigar",
                    LastName = "Aliyeva",
                    EmailAddress = "nigar.aliyeva@example.com",
                    GradeId = 2,
                    CreatedDate = DateTime.Now
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Samir",
                    LastName = "Hasanov",
                    EmailAddress = "samir.hasanov@example.com",
                    GradeId = 3,
                    CreatedDate = DateTime.Now
                },
                new Student
                {
                    Id = 4,
                    FirstName = "Leyla",
                    LastName = "Quliyeva",
                    EmailAddress = "leyla.quliyeva@example.com",
                    GradeId = 1,
                    CreatedDate = DateTime.Now
                },
                new Student
                {
                    Id = 5,
                    FirstName = "Murad",
                    LastName = "Karimov",
                    EmailAddress = "murad.karimov@example.com",
                    GradeId = 2,
                    CreatedDate = DateTime.Now
                },
                new Student
                {
                    Id = 6,
                    FirstName = "Aysel",
                    LastName = "Rahimova",
                    EmailAddress = "aysel.rahimova@example.com",
                    GradeId = 3,
                    CreatedDate = DateTime.Now
                },
                new Student
                {
                    Id = 7,
                    FirstName = "Elvin",
                    LastName = "Ismayilov",
                    EmailAddress = "elvin.ismayilov@example.com",
                    GradeId = 1,
                    CreatedDate = DateTime.Now
                }
            };
        }
    };


};


