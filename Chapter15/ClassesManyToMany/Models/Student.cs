namespace ClassesManyToMany.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Subject> Subjects { get; set; } = null!;
    }
}
