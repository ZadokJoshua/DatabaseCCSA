namespace DataConnections2.Models
{
    public class Subjects
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Teacher> Teacher { get; set; }
    }
}
