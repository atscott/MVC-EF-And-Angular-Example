
using System;
using System.Collections.Generic;
using MVC4AndEF6WithAngular.Data.Models;

namespace MVC4AndEF6WithAngular.Data.Dtos
{
    public class StudentDetailsDto
    {
        public int Id { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<EnrollmentDto> Enrollments { get; set; }
    }

    public class EnrollmentDto
    {
        public Grade Grade { get; set; }
        public string CourseTitle { get; set; }
    }
}