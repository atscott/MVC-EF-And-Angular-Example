using System.Collections.Generic;
using System.Linq;
using FakeDbSet;
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
        private Fixture _fixture;
        private InMemoryDbSet<Student> _inMemoryDbSet;

        public StudentServiceTests()
        {
            AutoMapperConfig.SetUp();
        }

        [TestInitialize]
        public void BeforeEach()
        {
            _fixture = new Fixture();
            _fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            _inMemoryDbSet = new InMemoryDbSet<Student>();
            _mockRepository = new Mock<IRepository<Student>>();

            _mockRepository
                .Setup(s => s.Get())
                .Returns(_inMemoryDbSet);

            _target = new StudentService(_mockRepository.Object);

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

            _inMemoryDbSet.Add(expected);

            var actual = _target.GetStudents();

            Assert.AreEqual(1, actual.Count());
            Assert.AreEqual(expected.FirstMidName, actual.First().FirstMidName);
        }

        [TestMethod]
        public void GetStudents_WhenManyStudentsExist_ReturnsThatSameListAsQueryable()
        {
            var students = new List<Student>();
            _fixture.AddManyTo(students);
            students.ForEach(f => _inMemoryDbSet.Add(f));

            var actual = _target.GetStudents();

            Assert.AreEqual(students.Count(), actual.Count());
        }

    }
}
