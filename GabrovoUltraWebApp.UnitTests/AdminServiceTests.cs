using GabrovoUltraWebApp.Core.Services;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using MockQueryable.Moq;
using Moq;

namespace GabrovoUltraWebApp.UnitTests
{

    [TestFixture]
        public class AdminServiceTests
        {
            private Mock<IRepository> _repositoryMock;
            private AdminService _adminService;

            [SetUp]
            public void Setup()
            {
                _repositoryMock = new Mock<IRepository>();
                _adminService = new AdminService(_repositoryMock.Object);
            }

            [Test]
            public async Task DeleteUser_ShouldReturnDeletedUser()
            {
                // Arrange
                var user = new ApplicationUser { Id = "1" };
                _repositoryMock.Setup(r => r.DeleteAsync<ApplicationUser>("1")).ReturnsAsync(user);

                // Act
                var result = await _adminService.DeleteUser("1");

                // Assert
                Assert.AreEqual(user, result);
            }

        [Test]
        public async Task GetAllUsers_ShouldReturnAllUsers()
        {
            // Arrange
            var users = new List<ApplicationUser> { new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37",
                Email = "sasho@gabrovoultra.bg",
                UserName = "sasho@gabrovoultra.bg",
                NormalizedEmail = "SASHO@GABROVOULTRA>BG",
                FirstName = "Sasho",
                LastName = "Sashov",
                NormalizedUserName = "SASHO@GABROVOULTRA>BG",
                City = "Gabrovo",
                Country = "Bulgaria",
                RegistrationId = 13,
            }, new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-aa228-55fb9bfa1f37",
                Email = "sasho@gabrovoultra.bg",
                UserName = "sasho@gabrovoultra.bg",
                NormalizedEmail = "SASHO@GABROVOULTRA>BG",
                FirstName = "Pesho",
                LastName = "Peshov",
                NormalizedUserName = "SASHO@GABROVOULTRA>BG",
                City = "Gabrovo",
                Country = "Bulgaria",
                RegistrationId = 14,
            }
        };
            var mock = users.AsQueryable().BuildMock();
            _repositoryMock.Setup(r => r.All<ApplicationUser>()).Returns(mock);

            // Act
            var result = await _adminService.GetAllUsers();

            // Assert
            Assert.That(result.Count, Is.EqualTo(users.Count));
        }


        [Test]
            public async Task UpdateUser_ShouldReturnUpdatedUser()
            {
                // Arrange
                var oldUser = new ApplicationUser { Id = "1", FirstName = "OldName" };
                var newUser = new AdminUpdateRequestDTO { FirstName = "NewName" };

                // Act
                var result = await _adminService.UpdateUser("1", newUser);

                // Assert
                Assert.AreEqual("NewName", result.FirstName);
            }
        }
    
}
