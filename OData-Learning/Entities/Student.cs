namespace OData_Learning.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; }=default!;
        public string EmailAddress { get; set; } = default!;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int GradeId { get; set; }
        public Grade Grade { get; set; }

    }
}
