using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC4AndEF6WithAngular.Data.Models
{
    [Table("tblcourse")]
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } 
    }
}