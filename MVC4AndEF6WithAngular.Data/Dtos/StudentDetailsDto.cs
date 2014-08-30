using System.Collections.Generic;
using MVC4AndEF6WithAngular.Data.Models;

namespace MVC4AndEF6WithAngular.Data.Dtos
{
    public class StudentDetailsDto : StudentDto
    {
        public ICollection<EnrollmentDto> Enrollments { get; set; }
    }

    public class EnrollmentDto
    {
        public Grade Grade { get; set; }
        public string CourseTitle { get; set; }
    }
}