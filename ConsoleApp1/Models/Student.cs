namespace DataConnections2.Models
{
    public class Student
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual School School { get; set; }
        public virtual List<Subjects> Subjects { get; set; }
        public virtual ClassRoom Class { get; set; }
    }
}
