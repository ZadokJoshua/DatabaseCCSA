using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnections2.Models
{
    public class School
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }
}
