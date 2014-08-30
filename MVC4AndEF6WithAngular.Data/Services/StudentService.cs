using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MVC4AndEF6WithAngular.Data.Contexts;
using MVC4AndEF6WithAngular.Data.Dtos;
using MVC4AndEF6WithAngular.Data.Models;

namespace MVC4AndEF6WithAngular.Data.Services
{
    public interface IStudentService
    {
        IList<StudentDto> GetStudents();
        StudentDetailsDto GetStudentDetails(int id);
    }

    public class StudentService : IStudentService
    {
        private readonly ISchoolContext _context;

        public StudentService(ISchoolContext context)
        {
            _context = context;
        }

        public IList<StudentDto> GetStudents()
        {
            return _context.Students
                .AsNoTracking()
                .Select(Mapper.Map<StudentDto>)
                .ToList();
        }

        public StudentDetailsDto GetStudentDetails(int id)
        {
            return Mapper.Map<StudentDetailsDto>(_context.Students.Find(id));
        }
    }
}