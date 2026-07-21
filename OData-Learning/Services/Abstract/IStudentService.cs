using OData_Learning.DTOs;
using OData_Learning.Entities;

namespace OData_Learning.Services.Abstract
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetAllStudents();
        public IEnumerable<Student> GetStudents();
        public IEnumerable<StudentDTO> GetAllStudentsFilter();
        public Student GetStudentsById(int id);
        public IEnumerable<Student> GetStudentGrade();
    }
}
