namespace ClassesManyToMany.Models
{
    public class StudentData
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public Student Student { get; set; }
    }
}
