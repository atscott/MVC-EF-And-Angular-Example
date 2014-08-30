
using System;

namespace MVC4AndEF6WithAngular.Data.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}