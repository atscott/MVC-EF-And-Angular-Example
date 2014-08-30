using MVC4AndEF6WithAngular.Data.Dtos;
using MVC4AndEF6WithAngular.Data.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace MVC4AndEF6WithAngular.Controllers.API
{
    public class StudentsController : ApiController
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [ActionName("default")]
        public IList<StudentDto> Get()
        {
            return _studentService.GetStudents();
        }

        [ActionName("default"), HttpGet]
        public StudentDetailsDto Details(int id)
        {
            return _studentService.GetStudentDetails(id);
        }
 
    }
}