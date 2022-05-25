namespace DataConnections2.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public School School { get; set; }
        public List<Subjects> Subjects { get; set; }
    }
}
