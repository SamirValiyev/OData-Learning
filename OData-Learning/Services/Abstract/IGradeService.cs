using OData_Learning.Entities;

namespace OData_Learning.Services.Abstract
{
    public interface IGradeService
    {
        public IEnumerable<Grade> GetAllGrades();

    }
}
