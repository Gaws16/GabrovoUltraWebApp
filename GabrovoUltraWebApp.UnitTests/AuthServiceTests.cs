using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.UnitTests
{
    using NUnit.Framework;
    using Moq;
    using GabrovoUltraWebApp.Core.Services;
    using GabrovoUltraWebApp.Infrastructure.Data.Models;
    using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Configuration;
    using System.Threading.Tasks;

    [TestFixture]
    public class AuthServiceTests
    {
        private Mock<UserManager<ApplicationUser>> _userManagerMock;
        private Mock<IConfiguration> _configMock;
        private AuthService _authService;

        [SetUp]
        public void Setup()
        {
            _userManagerMock = new Mock<UserManager<ApplicationUser>>(new Mock<IUserStore<ApplicationUser>>().Object, null, null, null, null, null, null, null, null);
            _configMock = new Mock<IConfiguration>();
            _authService = new AuthService(_userManagerMock.Object, _configMock.Object);
        }

        [Test]
        public async Task RegisterUser_ShouldReturnTrue_WhenUserIsCreatedSuccessfullyAndRolesAreAdded()
        {
            // Arrange
            var registerRequest = new RegisterRequestDTO
            {
                Username = "test@test.com",
                Password = "Test123!",
                Roles = new [] { "Admin" }
            };
            var user = new ApplicationUser { Email = "test@test.com", UserName = "test@test.com" };
            _userManagerMock.Setup(u => u.CreateAsync(It.IsAny<ApplicationUser>(), registerRequest.Password)).ReturnsAsync(IdentityResult.Success);
            _userManagerMock.Setup(u => u.AddToRolesAsync(It.IsAny<ApplicationUser>(), It.IsAny<IEnumerable<string>>())).ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await _authService.RegisterUser(registerRequest);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task GetUserIdAsync_ShouldReturnUserId_WhenUserExists()
        {
            // Arrange
            var username = "test@test.com";
            var user = new ApplicationUser { Id = "1", Email = username, UserName = username };
            _userManagerMock.Setup(u => u.FindByEmailAsync(username)).ReturnsAsync(user);

            // Act
            var result = await _authService.GetUserIdAsync(username);

            // Assert
            Assert.AreEqual(user.Id, result);
        }



        [Test]
        public async Task LoginUser_ShouldReturnTrue_WhenUserExistsAndPasswordIsValid()
        {
            // Arrange
            var loginRequest = new LoginRequestDTO { Username = "test@test.com", Password = "Test123!" };
            var user = new ApplicationUser { Email = "test@test.com", UserName = "test@test.com" };
            _userManagerMock.Setup(u => u.FindByEmailAsync(loginRequest.Username)).ReturnsAsync(user);
            _userManagerMock.Setup(u => u.CheckPasswordAsync(user, loginRequest.Password)).ReturnsAsync(true);

            // Act
            var result = await _authService.LoginUser(loginRequest);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task RegisterUser_ShouldReturnTrue_WhenUserIsCreatedSuccessfully()
        {
            // Arrange
            var registerRequest = new RegisterRequestDTO { Username = "test@test.com", Password = "Test123!" };
            var user = new ApplicationUser { Email = "test@test.com", UserName = "test@test.com" };
            _userManagerMock.Setup(u => u.CreateAsync(It.IsAny<ApplicationUser>(), registerRequest.Password)).ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await _authService.RegisterUser(registerRequest);

            // Assert
            Assert.IsTrue(result);
        }
    }

}
