using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using AutoMapper;
using MVC4AndEF6WithAngular.Data.Models;
using MVC4AndEF6WithAngular.Models;

namespace MVC4AndEF6WithAngular.Data.Services
{
    public interface IStudentService
    {
        IList<StudentDto> GetStudents();
    }

    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _repository;

        public StudentService(IRepository<Student> repository)
        {
            _repository = repository;
        }

        public IList<StudentDto> GetStudents()
        {
            return _repository
                .Get()
                .AsNoTracking()
                .Select(Mapper.Map<StudentDto>)
                .ToList();
        }
    }
}