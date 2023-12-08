using System.Collections.Generic;

namespace DI.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}