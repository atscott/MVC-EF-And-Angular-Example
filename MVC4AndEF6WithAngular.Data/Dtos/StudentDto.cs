
using System;
using System.ComponentModel;

namespace MVC4AndEF6WithAngular.Data.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }

        [DisplayName(@"First Name, MI")]
        public string FirstMidName { get; set; }

        [DisplayName(@"Last Name")]
        public string LastName { get; set; }

        [DisplayName(@"Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
    }
}