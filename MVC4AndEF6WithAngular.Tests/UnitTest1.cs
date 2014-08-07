using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MVC4AndEF6WithAngular.Controllers.API;
using MVC4AndEF6WithAngular.Data.Models;
using MVC4AndEF6WithAngular.Data.Services;
using Ploeh.AutoFixture;

namespace MVC4AndEF6WithAngular.Tests
{
    [TestClass]
    public class UnitTest1
    {

        private Fixture _fixture;
        private Mock<IStudentService> _mockStudentService;
        private StudentController _target;

        [TestInitialize]
        public void BeforeEach()
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
            var actual = _target.Get();

            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void Get_WhenStudentsExist_ReturnsSameNumberOfStudentsAsDtos()
        {
            _mockStudentService
                .Setup(s => s.GetStudents())
                .Returns(_fixture.CreateMany<Student>(3).AsQueryable());

            var actual = _target.Get();

            Assert.AreEqual(3, actual.Count);
        }
    }
}
