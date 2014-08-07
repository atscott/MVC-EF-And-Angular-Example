using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MVC4AndEF6WithAngular.Data.Models;
using MVC4AndEF6WithAngular.Data.Services;
using Ploeh.AutoFixture;

namespace MVC4AndEF6WithAngular.Data.Tests
{
    [TestClass]
    public class StudentServiceTests
    {
        private Mock<IRepository<Student>> _mockRepository;
        private StudentService _target;
        private HashSet<Student> _mockResponse;
        private Fixture _fixture;

        [TestInitialize]
        public void BeforeEach()
        {
            
            _mockRepository = new Mock<IRepository<Student>>();

            _mockResponse = new HashSet<Student>();

            _mockRepository
                .Setup(s => s.Query())
                .Returns(_mockResponse.AsQueryable());

            _target = new StudentService(_mockRepository.Object);

            _fixture = new Fixture();

            _fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

        [TestMethod]
        public void GetStudents_WhenNoStudents_ReturnsAnEmptyQueryable()
        {
            Assert.AreEqual(0, _target.GetStudents().Count());
        }

        [TestMethod]
        public void GetStudents_WhenStudentExists_ReturnsTheStudentAsQueryable()
        {
            var expected = _fixture.Create<Student>();

            _mockResponse.Add(expected);

            var actual = _target.GetStudents();

            Assert.AreEqual(1, actual.Count());
            Assert.AreEqual(expected, actual.First());
        }

        [TestMethod]
        public void GetStudents_WhenManyStudentsExist_ReturnsThatSameListAsQueryable()
        {
            _fixture.AddManyTo(_mockResponse);

            var actual = _target.GetStudents();

            Assert.AreEqual(_mockResponse.Count(), actual.Count());
        }

    }
}
