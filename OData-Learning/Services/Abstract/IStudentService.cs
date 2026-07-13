using OData_Learning.Entities;

namespace OData_Learning.Services.Abstract
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetAllStudents();
    }
}
