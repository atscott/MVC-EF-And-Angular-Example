using AutoMapper;
using MVC4AndEF6WithAngular.Data.Models;
using MVC4AndEF6WithAngular.Models;

namespace MVC4AndEF6WithAngular
{
    public class AutoMapperConfig
    {
        public static void SetUp()
        {
            Mapper.CreateMap<Student, StudentDto>();
        }
    }
}