using OData_Learning.Entities;
using OData_Learning.Services.Abstract;

namespace OData_Learning.Services.Concrete
{
    public class GradeService : IGradeService
    {
        public IEnumerable<Grade> GetAllGrades()
        {
            return new List<Grade>()
            {
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
            };
        }
    }
}
