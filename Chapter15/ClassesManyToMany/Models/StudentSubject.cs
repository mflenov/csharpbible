namespace ClassesManyToMany.Models
{
    public class StudentSubject
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public DateTime Enrolled { get; set; }
        public int Status { get; set; }
    }
}
