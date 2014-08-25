using AutoMapper;
using MVC4AndEF6WithAngular.Data.Services;
using MVC4AndEF6WithAngular.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVC4AndEF6WithAngular.Controllers.API
{
    public class StudentController : ApiController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [ActionName("default")]
        public IList<StudentDto> Get()
        {
            return _studentService.GetStudents();
        } 
    }
}