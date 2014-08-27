using System.Data.Entity;
using MVC4AndEF6WithAngular.Data.Models;

namespace MVC4AndEF6WithAngular.Data.Contexts
{
    public interface ISchoolContext
    {
        IDbSet<Course> Courses { get; set; } 
        IDbSet<Student> Students { get; set; } 
        IDbSet<Enrollment> Enrollments { get; set; } 

    }
    public class SchoolContext : DbContext
    {
        public IDbSet<Course> Courses { get; set; } 
        public IDbSet<Student> Students { get; set; } 
        public IDbSet<Enrollment> Enrollments { get; set; } 

        public SchoolContext(string connection): base(connection)
        {
            Database.SetInitializer<SchoolContext>(null);
        }
    }
}