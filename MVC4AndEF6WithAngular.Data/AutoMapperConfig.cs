using AutoMapper;
using MVC4AndEF6WithAngular.Data.Dtos;
using MVC4AndEF6WithAngular.Data.Models;

namespace MVC4AndEF6WithAngular.Data
{
    public class AutoMapperConfig
    {
        public static void SetUp()
        {
            Mapper.CreateMap<Student, StudentDto>();
            Mapper.CreateMap<Student, StudentDetailsDto>();
            Mapper.CreateMap<Enrollment, EnrollmentDto>();
        }
    }
}