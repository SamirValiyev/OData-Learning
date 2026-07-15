using OData_Learning.Entities;

namespace OData_Learning.Services.Abstract
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetAllStudents();
        public IEnumerable<Student> GetStudents();
        public IEnumerable<Student> GetAllStudentsFilter();
        public Student GetStudentsById(int id);
    }
}
