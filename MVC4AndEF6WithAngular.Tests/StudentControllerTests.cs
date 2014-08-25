using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MVC4AndEF6WithAngular.Controllers.API;
using MVC4AndEF6WithAngular.Data;
using MVC4AndEF6WithAngular.Data.Services;
using MVC4AndEF6WithAngular.Models;
using Ploeh.AutoFixture;
using System.Collections.Generic;
using System.Linq;

namespace MVC4AndEF6WithAngular.Tests
{
    [TestClass]
    public class StudentControllerTests
    {

        private Fixture _fixture;
        private Mock<IStudentService> _mockStudentService;
        private StudentController _target;

        [TestInitialize]
        public void StudenControllerTests()
        {
            _fixture = new Fixture();

            // client has a circular reference from AutoFixture point of view
            _fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            _mockStudentService = new Mock<IStudentService>();

            _target = new StudentController(_mockStudentService.Object);

            AutoMapperConfig.SetUp();
        }

        [TestMethod]
        public void Get_WhenNoStudents_ReturnsEmptyListOfDtos()
        {
            _mockStudentService
                .Setup(s => s.GetStudents())
                .Returns(new List<StudentDto>());

            var actual = _target.Get();

            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void Get_WhenStudentsExist_ReturnsSameNumberOfStudentsAsDtos()
        {
            _mockStudentService
                .Setup(s => s.GetStudents())
                .Returns(_fixture.CreateMany<StudentDto>(3).ToList());

            var actual = _target.Get();

            Assert.AreEqual(3, actual.Count);
        }
    }
}
