namespace DataConnections2.Models
{
    public class ClassRoom
    {
        public virtual int Id { get; set; }       
        public virtual string Name { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
