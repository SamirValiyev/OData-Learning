namespace OData_Learning.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<Student> Students { get; set; }
    }
}
