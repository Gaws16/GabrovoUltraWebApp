using NUnit.Framework;
using Moq;
using GabrovoUltraWebApp.Core.Services;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using System.Threading.Tasks;
namespace GabrovoUltraWebApp.UnitTests
{


    [TestFixture]
    public class DistanceServiceTests
    {
        private Mock<IRepository> _repositoryMock;
        private DistanceService _distanceService;

        [SetUp]
        public void Setup()
        {
            _repositoryMock = new Mock<IRepository>();
            _distanceService = new DistanceService(null, _repositoryMock.Object); // Passing null for GabrovoUltraContext as it's not used in the service
        }

        [Test]
        public async Task CreateAsync_ShouldReturnCreatedDistance()
        {
            // Arrange
            var distance = new Distance();
            _repositoryMock.Setup(r => r.AddAsync(distance)).Returns(Task.CompletedTask);

            // Act
            var result = await _distanceService.CreateAsync(distance);

            // Assert
            Assert.AreEqual(distance, result);
        }

        [Test]
        public async Task GetByIdAsync_ShouldReturnDistance()
        {
            // Arrange
            var distance = new Distance { Id = 1 };
            _repositoryMock.Setup(r => r.GetByIdAsync<Distance>(1)).ReturnsAsync(distance);

            // Act
            var result = await _distanceService.GetByIdAsync(1);

            // Assert
            Assert.AreEqual(distance, result);
        }
        [Test]
        public async Task DeleteAsync_ShouldReturnDeletedDistance()
        {
            // Arrange
            var distance = new Distance { Id = 1 };
            _repositoryMock.Setup(r => r.DeleteAsync<Distance>(1)).ReturnsAsync(distance);

            // Act
            var result = await _distanceService.DeleteAsync(1);

            // Assert
            Assert.AreEqual(distance, result);
        }

     

        [Test]
        public async Task UpdateAsync_ShouldReturnUpdatedDistance()
        {
            // Arrange
            var oldDistance = new Distance { Id = 1, Name = "OldName" };
            var newDistance = new Distance { Name = "NewName" };
            _repositoryMock.Setup(r => r.GetByIdAsync<Distance>(1)).ReturnsAsync(oldDistance);

            // Act
            var result = await _distanceService.UpdateAsync(1, newDistance);

            // Assert
            Assert.AreEqual("NewName", result.Name);
        }

    }
}